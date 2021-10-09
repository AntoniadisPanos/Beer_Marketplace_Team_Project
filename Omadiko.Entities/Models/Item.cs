using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Omadiko.Entities
{
    public class Item
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }
       
        public decimal Price { get; set; }
        public decimal TotalAmount { get; set; }
       
        public bool Purchase { get; set; }

        public virtual Order Order { get; set; }

        public virtual Product Product { get; set; }


        public static decimal Sum(decimal price,int quantity)
        {
            return price*quantity;
        }
       
    }
}