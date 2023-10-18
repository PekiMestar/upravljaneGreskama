using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upravljaneGreskama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int godRod;
            bool uspijeh = false;

            do
            {
                Console.WriteLine("Upiši svoju godinu rođenja: ");

                try
                {

                    godRod = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Rođen si " + godRod + ". godine.");

                    uspijeh = true;
                }

                catch (Exception greska)
                {
                    Console.WriteLine(greska.Message);

                    uspijeh=false;
                }
            }

            while (uspijeh == false);

            Console.ReadKey();
        }

    }
}
