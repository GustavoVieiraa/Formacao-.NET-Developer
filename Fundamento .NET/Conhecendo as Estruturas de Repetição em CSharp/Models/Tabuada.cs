using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conhecendo_as_Estruturas_de_Repetição_em_CSharp.Models
{
    public class Tabuada
    {
        public void chamadaTabuadaFor(int valTab) {
            Console.WriteLine("|---- Tabuada ----|");
            for (int c = 1; c <= 10; c++) {
                Console.WriteLine($"{valTab} x {c} = {valTab*c}");
            }
            Console.WriteLine("|----- Fim -----|");
        }

        public void chamadaTabuadaWhile(int valTab) {
            int cont = 1;
            Console.WriteLine("|---- Tabuada ----|");
            while (cont <= 10) {
                Console.WriteLine($"{valTab} x {cont} = {valTab*cont}");
                cont++;
            }
            Console.WriteLine("|----- Fim -----|");
        }
    }
}