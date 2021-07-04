using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Windows.Forms;


namespace Pharmacy.App_Code
{
    public class Encryption1
    {

      

        public string ComputeSha256Hash(string str)
        {

            string h0 = "01100111010001010010001100000001";
            string h1 = "11101111110011011010101110001001";
            string h2 = "10011000101110101101110011111110";
            string h3 = "00010000001100100101010001110110";
            string h4 = "11000011110100101110000111110000";
            string temp,f="",k="",help="",temp2="",final="";
            string[] mat = new string[80];
            int x = 15;

            string converted = string.Empty;
            // convert string to byte
            byte[] byteArray = Encoding.ASCII.GetBytes(str);


            for (int i = 0; i < byteArray.Length; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    converted += (byteArray[i] & 0x80) > 0 ? "1" : "0";
                    byteArray[i] <<= 1;
                }
            }
            temp = converted;

            while (help.Length < (64 - temp.Length))
            {
                help += "0";
            }
            help += temp;
            str = temp;
            str += "1";
            while(str.Length < 448)
            {
                str += "0";
            }
           



            str += help;
            int t = 0;
            for(int i = 0; i < 512; i++)
            {
                if (i % 32 == 0)
                    t++;
                mat[t] += str[i];
            }
            for (int i = 0; i < 64; i++)
            {

                mat[16+i] =rol(xor1(xor1(mat[x-3],mat[x-8]),xor1(mat[x-11],mat[x-13])));
                x++;
            }
            //x
            string a = h0;
            string b = h1;
            string c = h2;
            string d = h3;
            string e = h4;

            for(int i = 0; i < 80; i++)
            {

                if (0 <= i && i <= 19) {
                    f = or((and(b, c)), (and(not(b), d)));
                    k = "1011010100000100111100110011001";
                }
                else if (20 <= i && i <= 39) {
                    f = xor1(xor1(b, c), d);
                    k = "1101110110110011110101110100001";
                }
                else if (40 <= i && i <= 59) {
                    f = or(or(and(b, c), and(b, d)), and(c, d));
                    k = "10001111000110111011110011011100";
                }
                else if (60 <= i && i <= 79) {
                    f = xor1(xor1(b, c), d);
                    k = "11001010011000101100000111010110";
                }

                temp2 += and(rol(a) + f + e + k + mat[i], "11111111111111111111111111111111");
                e = d;
                d = c;
                c = rol(b);
                b = a;
                a = temp;
            }



            h0 = h0 + and(a,"11111111111111111111111111111111");
            h1 = h1 + and(b, "11111111111111111111111111111111");
            h2 = h2 + and(c, "11111111111111111111111111111111");
            h3 = h3 + and(d, "11111111111111111111111111111111");
            h4 = h4 + and(e, "11111111111111111111111111111111");
            final = h0 + h1 + h2 + h3 + h4;




            //x


            return BinaryStringToHexString(final.ToString());


        }

        public string xor1(string str1,string str2)
        {
            string temp = "";
            for (int i = 0; i < 16; i++)
            {
            
                if (str1[i] == str2[i])
                    temp += "0";
                else
                    temp += "1";
                
            }
            return temp;
        }


        public string rol(string str1)
        {
            string temp = "";
            for (int i = 0; i < 15; i++)
            {
                temp += str1[i + 1];

            }
            temp += str1[0];
            return temp;
        }

        public string and(string str1, string str2)
        {
            string temp = "";
            for (int i = 0; i < 16; i++)
            {
                if (str1[i]=='0' || str2[i]=='0')
                    temp += "0";
                else
                    temp += "1";

            }
            return temp;
        }

        public string or(string str1, string str2)
        {
            string temp = "";
            for (int i = 0; i < 16; i++)
            {
                if (str1[i] == '1' || str2[i] == '1')
                    temp += "1";
                else
                    temp += "0";

            }
            return temp;
        }

        public string not(string str1)
        {
            string temp = "";
            for (int i = 0; i < 16; i++)
            {
                if (str1[i] == '0')
                    temp += "1";
                else
                    temp += "0";

            }
            
            return temp;
        }

        public static string BinaryStringToHexString(string binary)
        {
            StringBuilder result = new StringBuilder(binary.Length / 8 + 1);

            // TODO: check all 1's or 0's... Will throw otherwise

            int mod4Len = binary.Length % 8;
            if (mod4Len != 0)
            {
                // pad to length multiple of 8
                binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');
            }

            for (int i = 0; i < binary.Length; i += 8)
            {
                string eightBits = binary.Substring(i, 8);
                result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
            }

            return result.ToString();
        }







    }

    
}

