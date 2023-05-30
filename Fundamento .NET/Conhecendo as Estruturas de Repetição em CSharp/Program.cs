// See https://aka.ms/new-console-template for more information

using Conhecendo_as_Estruturas_de_Repetição_em_CSharp.Models;

Console.WriteLine("=------- Estrutura FOR ------=");
Tabuada testeTabFor = new Tabuada();
testeTabFor.chamadaTabuadaFor(3);

Console.WriteLine("=------ Esturura WHILE ------=");
Tabuada testeTabWhile = new Tabuada();
testeTabWhile.chamadaTabuadaWhile(7);

Console.WriteLine("=----- Estrutura DO WHILE ------=");

do {
Console.WriteLine("Digite um número: ");
int num = Convert.ToInt32(Console.ReadLine());
num += num;
if (num > 1000) {
    break;
}
} while(true);