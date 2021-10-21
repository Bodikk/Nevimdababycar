using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Nevim a = new Nevim() { jmeno = "a", vek = 6 };
            Console.WriteLine(a.Nevimm());

            List<Zvire__> ab = new List<Zvire__>();
            ab.Add(new Zvire__(){ barva = "zelena", typ = "pták" }) ;
            foreach ( var item in ab)
            {
                Console.WriteLine(item.Ahoj());
            }
            Nevim b = new Nevim();
            b.jmeno = "Ahoj";
            bool aaa=false;
            if (b.jmeno == "Ahoj") aaa = true;
            int bbb = aaa ? 10 : 0;
            if (bbb == 10) Console.WriteLine("10 points for gryffindor");
            string aaaaaa=bbb.ToString();
            if (aaaaaa == "10") Console.WriteLine("deset");
            int[,] grid = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int y = 0; y < 10; y++)
                {
                    Console.Write(grid[i,y]+" ");
                }
                Console.WriteLine();
            }

            Nevim();
        }
        public static void Nevim()
        {
            var datum = new DateTime(2021, 11, 11);
            var datumted = DateTime.Now;
            Console.WriteLine(datum.ToLongDateString());
            Console.WriteLine(datumted.ToLongTimeString());


        }
    }
}
