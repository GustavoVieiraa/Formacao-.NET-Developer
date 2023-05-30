// See https://aka.ms/new-console-template for more information

using Conhecendo_as_Estruturas_de_Repetição_em_CSharp.Models;

/*

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

*/

/* Construção de MENU - Interativo*/

while(true) {
    Console.WriteLine("Escolha sua opção: ");
    Console.WriteLine("1 - Cadastrar novo Jogador");
    Console.WriteLine("2 - Buscar Jogador");
    Console.WriteLine("3 - Apagar Jogador");
    Console.WriteLine("4 - Encerrar Jogo");
    string opcao = Console.ReadLine();
    switch(opcao) 
    {
        case "1":
            Console.WriteLine("|--- Cadastro do Cliente ---|");
            break;
        case "2":
            Console.WriteLine("|--- Buscar Jogador ---|");
            break;
        case "3":
            Console.WriteLine("|--- Apagar Jogador ---|");
            break;
        case "4":
            Console.WriteLine("Jogo Encerrado!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Opção invalida!");
            break;
    }
}