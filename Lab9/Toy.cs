using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class Toy
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Toy(string title, decimal price, int quantity)
        {
            Title = title;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{Title} -> {Price} $";
        }



        public override int GetHashCode()
        {
            return HashCode.Combine(Title, Price, Quantity);
        }

        public override bool Equals(object obj)
        {
            return obj is Toy toy &&
                   Title == toy.Title &&
                   Price == toy.Price &&
                   Quantity == toy.Quantity;
        }
    }
}
