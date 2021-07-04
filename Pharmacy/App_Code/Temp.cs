using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pharmacy.App_Code
{
    public class Temp
    {
        private String orderId;
        private String barcode;
        private int quantity;

        public string OrderId
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

        public Temp()
        {

        }

        public Temp(string orderId, string barcode, int quantity)
        {
            this.orderId = orderId;
            this.barcode = barcode;
            this.quantity = quantity;
        }
    }
}