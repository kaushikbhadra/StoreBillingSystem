﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSyatem.BLL
{
    class TransactionDetailsBLL
    {
        public int id { get; set; }
        public int product_id { get; set; }
        public decimal rate { get; set; }
        public  decimal qty { get; set; }
        public decimal total { get; set; }
        public int delr_cust_id { get; set; }
        public DateTime added_date { get; set; }
        public int added_by { get; set; }


    }
}
