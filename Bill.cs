﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1.DTO
{
    public class Bill
    {
        public Bill(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int status)
        {
            this.Id = id;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.Status = status;
        }
        public Bill(DataRow row)
        {
            this.Id = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckIn"];
            var dataCheckOutTemp = row["dateCheckOut"];
            if (dataCheckOutTemp.ToString ()!= "" )
            {
                this.DateCheckOut = (DateTime?)dataCheckOutTemp;
            }
            this.Status = (int)row["status"];
        }

        private int status;
        public int Status
        {
            get { return status; }
            set { status = value; }
        }

        private DateTime? dateCheckIn;
        public DateTime? DateCheckIn
        {
            get { return dateCheckIn; }
            set { dateCheckIn = value; }
        }

        private DateTime? dateCheckOut;
        public DateTime? DateCheckOut
        {
            get { return dateCheckOut; }
            set { dateCheckOut = value; }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }
}
