// See https://aka.ms/new-console-template for more information

using Operadores_Aritméticos_em_CSharp.Models;

// Operadores Aritméticos
int a = 5;
int b = 10;

int c = a-b;
int d = a*b;
int e = a/b;
int f = a+b;

/*
Console.WriteLine($"{a} - {b} = {c} \n {a} x {b} = {d} \n {a} / {b} = {e} \n {a} + {b} = {f}");
*/

Calculadora calc1 = new Calculadora();
calc1.Somar(20, 30);
calc1.Multiplicar(10, 10);

