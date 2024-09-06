using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubStitutePattern
{
    public class Car : ICar
    {
      public void Start()
        {
            Console.WriteLine("Car  went ...");
        } 
    }
}
