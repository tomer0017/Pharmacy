using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;


namespace Pharmacy.App_Code
{
    public class Order1
    {
        private int orderId;
        private String cid;
        private String wid;
        private int flag;

        public int OrderId
        {
            get
            {
                return orderId;
            }

            set
            {
                orderId = value;
            }
        }

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

        public int Flag
        {
            get
            {
                return flag;
            }

            set
            {
                flag = value;
            }
        }

        public Order1()
        {

        }

        public Order1(string cid, string wid)
        {
            this.cid = cid;
            this.wid = wid;
            this.flag = 0;

        }

        public void addOrder()
        {
            string sql = "INSERT INTO Order2 (Cid,Wid,Flag) Values(";
            sql += "'" + cid + "',";
            sql += "'" + wid + "',";
            sql += "'" + flag + "')";
            Connection MyQuery = new Connection();
            MyQuery.OpenConection();
            MyQuery.ExecuteQueries(sql);

        }

        public void findOrder()
        {
            try
            {
                Connection c = new Connection();
                string sql = "select OrderId,Flag FROM Order2 WHERE OrderId = (SELECT MAX(OrderId) FROM Order2)";
                c.OpenConection();
                OleDbDataReader dr = c.DataReader(sql);
                if (dr.Read())
                {
                    orderId = int.Parse(dr["OrderId"].ToString());
                    flag = int.Parse(dr["Flag"].ToString());

                }

            }
            
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void updateOrder()
        {

            string sql = "Update Order2 Set Flag=1 WHERE OrderId=" + orderId;
            Connection MyQuery = new Connection();
            MyQuery.OpenConection();
            MyQuery.ExecuteQueries(sql);


        }
    }
}