using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_static
{
    public class AirPlane
    {
        static private int count = 0; 
        private string name;
        private string num;

        public AirPlane(string name, string num)
        {
            this.name = name;
            this.num = num;
            count++;
        }

        public void printInfo()
        {
            Console.WriteLine("Airplane name: {0}, num: {1}", this.name, this.num);
        }

        public void printCount()
        {
            Console.WriteLine(count);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            AirPlane airPlane1 = new AirPlane("아시아나", "707");

            airPlane1.printCount();


        }
    }
}
