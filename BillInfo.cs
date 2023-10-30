using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DTO
{
    public class BillInfo
    {
        public BillInfo(int id,int count, int foodID, int billID)
        {
            this.Id = id;
            this.Count = count;
            this.FoodID = foodID;
            this.BillID = billID;
        }

        public BillInfo(DataRow row)
        {
            this.Id = (int)row["id"];
            this.BillID = (int)row["idBill"];
            this.FoodID = (int)row["idFood"];
            this.Count = (int)row["count"];
        }


        private int count;
        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private int foodID;
        public int FoodID
        {
            get { return foodID; }
            set { foodID = value; }
        }

        private int billID;
        public int BillID
        {
            get { return billID; }
            set { billID = value; }
        }

        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }


    }
}
