using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplianceAbstractPrcatice
{
    class Program
    {
        static void Main(string[] args)
        {
            Microwave myMicrowave = new Microwave(1000, "Samsung");
            Dishwasher myDishwasher = new Dishwasher(0, true);

            myMicrowave.Work();
            myDishwasher.Work();


        }
    }
}
