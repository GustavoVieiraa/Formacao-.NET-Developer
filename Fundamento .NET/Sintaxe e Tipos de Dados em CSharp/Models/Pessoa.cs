using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sintaxe_e_Tipos_de_Dados_em_CSharp_.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public void SeApresentar() {
            Console.WriteLine($"Olá, meu nome é {Nome} e eu tenho {Idade} anos.");
        }
    }

    public class Convensoes
    {
        public string ConvensaoCamel = "camelCase";
        public string ConvensaoPascalCase = "PascalCase";
        public string ConvensaoSnake_case = "Snake_case";
        public string Convensaospinal_case = "spinal-case";

        public void ExplicacaoConvensoes() {
            Console.WriteLine($"Em C# nós utilizamos o Camel e o PascalCase.\n Convensão Camel = {ConvensaoCamel} \n Convensão PascalCase = {ConvensaoPascalCase} \n Convensão Snake case = {ConvensaoSnake_case} \n Convensão Spinal case = {Convensaospinal_case} ");
        }
    }
}

