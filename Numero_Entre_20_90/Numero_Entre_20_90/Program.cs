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
            
            int numero;
            Console.Title = "SENAC";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine  ("╔════════════════════════════════════════════════════════════════╗");
            Console.WriteLine  ("║                                                                ║");
            Console.WriteLine  ("║ █░█ ▄▀█ █░░ █▀█ █▀█ █▀▀ █▀       █ █▄░█ ▀█▀ █▀▀ █ █▀█ █▀█ █▀   ║"); 
            Console.WriteLine  ("║ ▀▄▀ █▀█ █▄▄ █▄█ █▀▄ ██▄ ▄█       █ █░▀█ ░█░ ██▄ █ █▀▄ █▄█ ▄█   ║");
            Console.WriteLine  ("║                                                                ║");
            Console.WriteLine  ("╚════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.Write("\r\r Construa um algoritmo que indique se um número digitado está compreendido entre 20 e 90 ou não (20 e 90 não estão na \n faixa de valores).");
            Console.ResetColor();
            Console.Write("\n\n Digite um número: ");
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
    

