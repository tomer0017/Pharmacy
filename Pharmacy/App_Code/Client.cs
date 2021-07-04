using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;


namespace Pharmacy.App_Code
{
    public class Client
    {
        private string cid;
        private string firstName;
        private string lastName;
        private string street;
        private string phoneNumber;
        private string dateOfBirth;
        private string email;
        private string gender;
        private int classification;

        public string Cid
        {
            get
            {
                return cid;
            }

            set
            {
                cid = value;
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

        public int Classification
        {
            get
            {
                return classification;
            }

            set
            {
                classification = value;
            }
        }


        public Client()
        {

        }

        
        public Client(string cid, string firstName, string lastName, string street, string phoneNumber, string dateOfBirth, string email, string gender,int classification)
        {
            this.cid = cid;
            this.firstName = firstName;
            this.lastName = lastName;
            this.street = street;
            this.phoneNumber = phoneNumber;
            this.dateOfBirth = dateOfBirth;
            this.email = email;
            this.gender = gender;
            this.classification = classification;
        }

        public void addClient()
        {
            string sql = "INSERT INTO Client Values(";
            sql += "'" + cid + "',";
            sql += "'" + firstName + "',";
            sql += "'" + lastName + "',";
            sql += "'" + street + "',";
            sql += "'" + phoneNumber + "',";
            sql += "'" + dateOfBirth + "',";
            sql += "'" + email + "',";
            sql += "'" + gender + "',";
            sql += "'" + classification + "')";
            Connection MyQuery = new Connection();
            MyQuery.OpenConection();
            MyQuery.ExecuteQueries(sql);

        }

        public void findClientId(string clientId)
        {
            try
            {
                Connection c = new Connection();
                string sql = "SELECT * FROM Client WHERE Cid=";
                sql += "'" + clientId + "'";
                c.OpenConection();
                OleDbDataReader dr = c.DataReader(sql);
                if (dr.Read())
                {
                    this.cid = dr["Cid"].ToString();
                    this.firstName = dr["FirstName"].ToString();
                    this.lastName = dr["LastName"].ToString();
                    this.street = dr["Street"].ToString();
                    this.phoneNumber = dr["PhoneNumber"].ToString();
                    this.dateOfBirth = dr["DateOfBirth"].ToString();
                    this.email = dr["Email"].ToString();
                    this.gender = dr["Gender"].ToString();
                    this.classification = int.Parse(dr["Classification"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateClient(string clientId)
        {
            string sql = "Update Client Set Cid=";
            sql += "'" + cid + "',";
            sql += "FirstName='" + firstName + "',";
            sql += "LastName='" + lastName + "',";
            sql += "Street='" + street + "',";
            sql += "PhoneNumber='" + phoneNumber + "',";
            sql += "DateOfBirth='" + dateOfBirth + "',";
            sql += "Email='" + email + "',";
            sql += "Gender='" + gender + "',";
            sql += "Classification='" + classification + "'";
            Connection MyQuery = new Connection();
            MyQuery.OpenConection();
            MyQuery.ExecuteQueries(sql);

        }

        public void deleteClient(string clientId)
        {
            string sql = "Delete from Client where Cid=";
            sql += "'" + clientId + "'";
            Connection MyQuery = new Connection();
            MyQuery.OpenConection();
            MyQuery.ExecuteQueries(sql);
        }







    }
}