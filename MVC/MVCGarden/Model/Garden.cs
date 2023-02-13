using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCGarden.Model
{
    public class Garden
    {
        public Garden(decimal priceVegitables, decimal priceFruits, int kgVegitable, int kgFruits)
        {
            PriceVegitables = priceVegitables;
            PriceFruits = priceFruits;
            KgVegitable = kgVegitable;
            KgFruits = kgFruits;
        }

        public decimal PriceVegitables { get; set; }
        public decimal PriceFruits { get; set; }
        public int KgVegitable { get; set; }
        public int KgFruits { get; set; }
        public decimal CalculateSum()
        {
            return (this.KgFruits * this.PriceFruits + this.KgVegitable * this.PriceVegitables)/1.94m;
        }
    }
}
