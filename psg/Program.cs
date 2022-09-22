using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace psg
{
    class Program
    {
        static void Main(string[] args)
        {
            player mbappe = new player();
            Monster monster1 = new Monster();
            mbappe.ADDAt(10);
            Console.WriteLine(mbappe.at);
            Console.WriteLine(monster1.at);
            Console.ReadLine();


            

           


        }
    }
}
