using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Pharmacy.App_Code
{
    public class Worker
    {
        private string wid;
        private string firstName;
        private string lastName;
        private string dateOfBirth;
        private string street;
        private string phoneNumber;
        private string email;
        private string gender;
        private string username;
        private string password;
        private string premissions;
        private string pic;
        private int count;
        private int block;

        public string Wid
        {
            get
            {
                return wid;
            }

            set
            {
                wid = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }

            set
            {
                dateOfBirth = value;
            }
        }

        public string Street
        {
            get
            {
                return street;
            }

            set
            {
                street = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Premissions
        {
            get
            {
                return premissions;
            }

            set
            {
                premissions = value;
            }
        }

        public string Pic
        {
            get
            {
                return pic;
            }

            set
            {
                pic = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        public int Block
        {
            get
            {
                return block;
            }

            set
            {
                block = value;
            }
        }

        public Worker()
        {

        }

        public Worker(string wid, string firstName, string lastName, string dateOfBirth, string street, string phoneNumber, string email, string gender, string username, string password, string premissions)
        {
            this.wid = wid;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.street = street;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.gender = gender;
            this.username = username;
            this.password = password;
            this.premissions = premissions;
            this.count = 0;
            this.block = 0;
            
        }

        public Worker( int block,int count)
        {
            this.block = block;
            this.count = count;
         
        }

        public void findWork(string usr)
        {
            try
            {
                Connection c = new Connection();
                string sql = "SELECT * FROM Worker WHERE Username=";
                sql += "'" + usr + "'";
                c.OpenConection();
                OleDbDataReader dr = c.DataReader(sql);
                if(dr.Read())
                {
                    this.wid = dr["Wid"].ToString();
                    this.firstName = dr["FirstName"].ToString();
                    this.lastName = dr["LastName"].ToString();
                    this.dateOfBirth = dr["DateOfBirth"].ToString();
                    this.street = dr["Street"].ToString();
                    this.phoneNumber = dr["PhoneNumber"].ToString();
                    this.email = dr["Email"].ToString();
                    this.gender = dr["Gender"].ToString();
                    this.username = dr["Username"].ToString();
                    this.password = dr["Password"].ToString();
                    this.premissions = dr["Premissions"].ToString();
                    this.count = int.Parse(dr["Count"].ToString());
                    this.block = int.Parse(dr["Block"].ToString());
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public void findWorkId(string workId)
        {
            try
            {
                Connection c = new Connection();
                string sql = "SELECT * FROM Worker WHERE Wid=";
                sql += "'" + workId + "'";
                c.OpenConection();
                OleDbDataReader dr = c.DataReader(sql);
                if (dr.Read())
                {
                    this.wid = dr["Wid"].ToString();
                    this.firstName = dr["FirstName"].ToString();
                    this.lastName = dr["LastName"].ToString();
                    this.dateOfBirth = dr["DateOfBirth"].ToString();
                    this.street = dr["Street"].ToString();
                    this.phoneNumber = dr["PhoneNumber"].ToString();
                    this.email = dr["Email"].ToString();
                    this.gender = dr["Gender"].ToString();
                    this.username = dr["Username"].ToString();
                    this.password = dr["Password"].ToString();
                    this.premissions = dr["Premissions"].ToString();
                    this.count = int.Parse(dr["Count"].ToString());
                    this.block = int.Parse(dr["Block"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void addWork()
        {
            Encryption1 ab =new Encryption1();
            try
            {
                password = ab.ComputeSha256Hash(password);
            }
            catch { }
            string sql = "INSERT INTO Worker Values(";
            sql += "'" + wid + "',";
            sql += "'" + firstName + "',";
            sql += "'" + lastName + "',";
            sql += "'" + dateOfBirth + "',";
            sql += "'" + street + "',";
            sql += "'" + phoneNumber + "',";
            sql += "'" + email + "',";
            sql += "'" + gender + "',";
            sql += "'" + username + "',";
            sql += "'" + password + "',";
            sql += "'" + premissions + "',";
            sql += "'" + 0 + "',";
            sql += "'" + 0 + "')";
          
            Connection MyQuery = new Connection();
            MyQuery.OpenConection();
            MyQuery.ExecuteQueries(sql);

            
        }

        public void updateWork(string WorkId)
        {
            string sql = "Update Worker Set Wid=";
            sql += "'" + wid + "',";
            sql += "FirstName='" + firstName + "',";
            sql += "LastName='" + lastName + "',";
            sql += "DateOfBirth='" + dateOfBirth + "',";
            sql += "Street='" + street + "',";
            sql += "PhoneNumber='" + phoneNumber + "',";
            sql += "Email='" + email + "',";
            sql += "Gender='" + gender + "',";
            sql += "Username='" + username + "',";
            sql += "Password='" + password + "',";
            sql += "Premissions='" + premissions + "'";
            Connection MyQuery = new Connection();
            MyQuery.OpenConection();
            MyQuery.ExecuteQueries(sql);

        }

        public string removeBlock(string WorkId)
        {
            string sql = "Update Worker Set Block=0 ,Count=0 where Wid=";
            sql += "'" + wid + "'";
            Connection MyQuery = new Connection();
            MyQuery.OpenConection();
            MyQuery.ExecuteQueries(sql);
            return sql;
        }

        public string upCount(string WorkId)
        {
            string sql = "Update Worker Set Count=Count+1 where Wid=";
            sql += "'" + wid + "'";
            Connection MyQuery = new Connection();
            MyQuery.OpenConection();
            MyQuery.ExecuteQueries(sql);
            return sql;
        }

        public string blockWorker(string WorkId)
        {
            string sql = "Update Worker Set Block=1 where Wid=";
            sql += "'" + wid + "'";
            Connection MyQuery = new Connection();
            MyQuery.OpenConection();
            MyQuery.ExecuteQueries(sql);
            return sql;
        }


        public void deleteWork(string WorkId)
        {
            string sql = "Delete from Worker where Wid=";
            sql += "'" + WorkId + "'";
            Connection MyQuery = new Connection();
            MyQuery.OpenConection();
            MyQuery.ExecuteQueries(sql);
        }

        
    }
}