using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Pharmacy.App_Code
{
    public class Medicine
    {
        private string barcode;
        private string name;
        private string type;
        private float price;
        private string description;
        private int quantity;
        private string company;
        private string picture;
        private int classification;

        public string Barcode
        {
            get
            {
                return barcode;
            }

            set
            {
                barcode = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }

        public string Company
        {
            get
            {
                return company;
            }

            set
            {
                company = value;
            }
        }

        public string Picture
        {
            get
            {
                return picture;
            }

            set
            {
                picture = value;
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

        public Medicine()
        {

        }

        public Medicine(string name, string type, float price, string description,int quantity, string company, string picture, int classification)
        {
            this.name = name;
            this.type = type;
            this.price = price;
            this.description = description;
            this.quantity = quantity;
            this.company = company;
            this.picture = picture;
            this.classification = classification;
        }

        public void AddMed()
        {
            string sql = "INSERT INTO Medicine Values(";
            sql += "'" + name + "',";
            sql += "'" + type + "',";
            sql += "'" + price + "',";
            sql += "'" + description + "',";
            sql += "'" + quantity + "',";
            sql += "'" + company + "',";
            sql += "'" + picture + "',";
            sql += "'" + classification + "')";
            Connection MyQuery = new Connection();
            MyQuery.OpenConection();
            MyQuery.ExecuteQueries(sql);


        }
        public void findMedName(string medName)
        {
            try
            {
                Connection c = new Connection();
                string sql = "SELECT * FROM Medicine WHERE Name=";
                sql += "'" + medName + "'";
                c.OpenConection();
                OleDbDataReader dr = c.DataReader(sql);
                if (dr.Read())
                {
                    this.Name= dr["Name"].ToString();
                    this.Type = dr["Type"].ToString();
                    this.price = float.Parse(dr["Price"].ToString());
                    this.Description = dr["Description"].ToString();
                    this.Quantity = int.Parse(dr["Quantity"].ToString());
                    this.Company = dr["Company"].ToString();
                    this.Picture = dr["Pic"].ToString();
                    this.classification = int.Parse(dr["Classification"].ToString());
                   
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void findMedByBar(string Barcode)
        {
            try
            {
                Connection c = new Connection();
                string sql = "SELECT * FROM Medicine WHERE Barcode=";
                sql += "'" + Barcode + "'";
                c.OpenConection();
                OleDbDataReader dr = c.DataReader(sql);
                if (dr.Read())
                {
                    this.Name = dr["Name"].ToString();
                    this.Type = dr["Type"].ToString();
                    this.price = float.Parse(dr["Price"].ToString());
                    this.Description = dr["Description"].ToString();
                    this.Quantity = int.Parse(dr["Quantity"].ToString());
                    this.Company = dr["Company"].ToString();
                    this.Picture = dr["Pic"].ToString();
                    this.classification = int.Parse(dr["Classification"].ToString());

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateMed(string Name)
        {

            string sql = "Update Medicine Set Name=";
            sql += "'" + Name + "',";
            sql += "Type='" + Type + "',";
            sql += "Price='" + Price + "',";
            sql += "Description='" + Description + "',";
            sql += "Quantity='" + Quantity + "',";
            sql += "Company='" + Company + "',";
            sql += "Pic='" + Picture + "'";
           
            Connection MyQuery = new Connection();
            MyQuery.OpenConection();
            MyQuery.ExecuteQueries(sql);

        }


        public void deleteMed(string Name)
        {
            string sql = "Delete from Medicine where Name=";
            sql += "'" + Name + "'";
            Connection MyQuery = new Connection();
            MyQuery.OpenConection();
            MyQuery.ExecuteQueries(sql);
        }

    }
}