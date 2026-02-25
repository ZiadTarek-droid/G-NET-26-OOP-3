using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public sealed class Projector
    {
        public void Start()
        {
            Console.WriteLine("Projector started.");
        }

        public void Stop()
        {
            Console.WriteLine("Projector stopped.");
        }
    }
}
