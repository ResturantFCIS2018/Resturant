using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Food
    {

        public string id , name , quantity , price, discount;
        public Food() { }
        public Food(string id, string name, string quan, string price, string discount)
        {
            this.id         = id;
            this.name       = name;
            this.quantity   = quan;
            this.price      = price;
            this.discount   = discount;
        }
        public bool validFOOD()
        {
            if(this.name == "" || this.price == "" || this.quantity == "" || this.id == "" || this.discount == "")
            {
                return false;
            }
            return true;
        }
    }
}
