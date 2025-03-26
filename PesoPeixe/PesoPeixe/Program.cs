using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesoPeixe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, sobra;
            Console.Write("digite o peso pescado: ");
            peso = int.Parse(Console.ReadLine());
            sobra = (peso - 50) * 4;
            Console.Write(sobra);
        }
    }
}
