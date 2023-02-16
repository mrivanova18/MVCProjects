using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCTransport.Views
{
    public class Display
    {
        public Display()
        {
            this.Km = 0;
            this.TimeOfDay = string.Empty;
            this.TotalPrice = 0;
            this.GetValues();
        }

        public int Km { get; set; }
        public string TimeOfDay { get; set; }
        public double TotalPrice { get; set; }
        public void GetValues()
        {
            this.Km = int.Parse(Console.ReadLine());
            this.TimeOfDay = Console.ReadLine();
        }
        public void ShowResults()
        {
            Console.WriteLine($"{this.TotalPrice:f2}");
        }
    }
}
