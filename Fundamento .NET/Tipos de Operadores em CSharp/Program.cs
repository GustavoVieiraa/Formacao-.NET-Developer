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