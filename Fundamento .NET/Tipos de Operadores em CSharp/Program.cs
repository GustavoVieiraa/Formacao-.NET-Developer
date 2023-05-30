// See https://aka.ms/new-console-template for more information
// Atribuições simples
int a = 6;
int b = 3;
int c = a+b;
Console.WriteLine($"{a} + {b} = {c}");

// Combinando Operadores
// c = c + 10;
c += 10;
Console.WriteLine($"9 + 10 = {c}");

// Conversão de Int to String
int gValor = Convert.ToInt32("24");
gValor += 10;
Console.WriteLine(gValor);

// Conversão de Int to String - Parse
int tValor = int.Parse("20");
tValor += 20;
Console.WriteLine(tValor);

// Diferença entre o Parse e o Convert
/*  Convert aceita valores Null para conversão
    Parse não aceita valores Null para conversão.
*/

// Conversão To String
int inteiroValor = 120;
string aString  = inteiroValor.ToString();
Console.WriteLine(aString);

// Conversão de maneira segura
Console.WriteLine("=---------------= Teste =---------------=");
string y = "53186988837";
long resultY = 0;

long.TryParse(y, out resultY);
if (resultY == 0) {
    Console.WriteLine("Operação Finalizada, não foi convertido, pois foi encontrado um ERRO!");

} else {
    Console.WriteLine(resultY);
    Console.WriteLine("Operação Finalizada, com êxito!");
}

// Aplicando Operador condicional na prática
Console.WriteLine("=----------- LOJA -----------=");
int CamisasDisponiveis = 10;
int CamisasSolicitadas = 11;
bool possivelVenda = CamisasDisponiveis >= CamisasSolicitadas;

if (possivelVenda) {
    Console.WriteLine("Você pode realizar a compra!");
    Console.WriteLine($"Estoque: {CamisasDisponiveis}");
    Console.WriteLine($"Camisas Solicitadas: {CamisasSolicitadas}");
    Console.WriteLine("=-----------------------------=");
} else {
    Console.WriteLine("Você não pode realizar a compra! \n Estoque Indisponível!");
    Console.WriteLine("=-----------------------------=");
}
