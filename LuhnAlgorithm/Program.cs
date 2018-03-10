using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuhnAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            CNumber Nombre = null;
            do
            {
                Console.WriteLine("Entrez une serie de chiffres");
                string ok = Console.ReadLine();
                Nombre = new CNumber(ok);
                Console.WriteLine(Nombre.Verify());

            } while (true);
        }
    }
}
