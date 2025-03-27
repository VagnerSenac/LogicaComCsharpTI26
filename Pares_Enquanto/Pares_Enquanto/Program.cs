using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pares_Enquanto
{
    internal class Program
    {
        static void Main(string[] args)
        {
    int contadorPares = 0;

    while(contadorPares <= 100)

    //enquanto = while
    {
      if(contadorPares % 2 == 0)
      {
         Console.WriteLine(contadorPares);
      }
      contadorPares++;
    }
  


        }
    }
}
