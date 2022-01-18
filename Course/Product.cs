using System;

namespace Course
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public double TotalValueinStock()
        { 
            return Price * Quantity;
        } 

        public void RemoveProduct(int quantity)
        { 
            Quantity -= quantity;
        }

        public void AddProduct(int quantity)
        {
            Quantity += quantity;
        }


    }
}
