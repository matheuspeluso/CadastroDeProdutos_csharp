using System;
using System.Globalization;

namespace CadastroDeProdutosEx.Entities
{
    internal class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        virtual public string PriceTag()
        {
            return Name + " $ " + Price.ToString("f2",CultureInfo.InvariantCulture);
        }
    }
}
