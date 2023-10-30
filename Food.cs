using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DTO
{
    public class Food
    {
        public Food(int id, string name, float price, int categoryID)
        {
            this.CategoryID = categoryID;
            this.Id = id;
            this.Price = price;
            this.Name = name;
        }

        public Food(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();
            this.CategoryID = (int)row["idcategory"];
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
        }

        private float price;
        public float Price 
        {
            get { return price; }
            set { price = value; }
        }

        private int categoryID;
        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
