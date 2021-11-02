using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace uinttesting
{

    class Program
    {
        static int health = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("unit testing");
            Console.WriteLine();

            unitTest();
            // RunGame

            Console.ReadKey(true);
        }

        static void Heal(int hp)
        {
            
            health += hp;
        }

        static void unitTest()
        {
            Heal(10);
            Debug.Assert(health <= 100);
            //Debug.Assert(2 + 2 == 4);
            //Debug.Assert(2 + 2 == 5);
           //if (health > 100)
            {

            }
        }
    }
}
