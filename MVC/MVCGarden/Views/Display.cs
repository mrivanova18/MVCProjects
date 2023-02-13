using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCGarden.Views
{
    public class Display
    {
        public Display()
        {
            PriceVegitables = 0;
            PriceFruits = 0;
            KgVegitable = 0;
            KgFruits = 0;
            this.GetValues();
        }

        public decimal PriceVegitables { get; set; }
        public decimal PriceFruits { get; set; }
        public int KgVegitable { get; set; }
        public int KgFruits { get; set; }
        public decimal Total { get; set; }
        public void GetValues()
        {
            this.PriceVegitables = decimal.Parse(Console.ReadLine());
            this.PriceFruits = decimal.Parse(Console.ReadLine());
            this.KgVegitable = int.Parse(Console.ReadLine());
            this.KgFruits = int.Parse(Console.ReadLine());
        }
        public void ShowResults()
        {
            Console.WriteLine(this.Total);
        }
    }
}
