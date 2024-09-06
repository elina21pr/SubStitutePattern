using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubStitutePattern
{
    public class CarProxy : ICar
    {
        private Car realCar;
        private bool hasAccess;

        public CarProxy(bool hasAccess)
        {
            this.hasAccess = hasAccess;
            this.realCar = new Car();
        }

        public void Start()
        {
            if (hasAccess)
            {
                Console.WriteLine("Access to the car true. Starting car... ");
                realCar.Start();
            }
            else
            {
                Console.WriteLine("There is no access to the car. The car is standing...");
            }
        }
    }
}
