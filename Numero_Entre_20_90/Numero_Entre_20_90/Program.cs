using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_Entre_20_90
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Construa um algoritmo que indique se um número digitado está compreendido entre 20 e 90 ou não (20 e 90 não estão na faixa de valores). 
            int numero;
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            if(numero > 20 && numero < 90)
                // if = SE
                // && =  e
                
                  {
                Console.Write("Numero está entre 20 e 90");
    }
                    else
                    // else = senão
                  {
                Console.Write("Numero não está entre 20 e 90");
    }
                }
            }


        }
    

