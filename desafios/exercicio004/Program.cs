// a) maior e menor entre tres numeros
System.Console.WriteLine("digite um número inteiro: ");
int num1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("digite o segundo número inteiro: ");
int num2 = int.Parse(Console.ReadLine());

System.Console.WriteLine("digite o terceiro número inteiro: ");
int num3 = int.Parse(Console.ReadLine());

int maior = num1;
int menor = num1;

if (num2 > maior)
{
    maior = num2;
}
if (num3 > maior)
{
    maior = num3;
}
if (num2 < menor)
{
    menor = num2;
}
if (num3 < menor)
{
    menor = num3;
}

System.Console.WriteLine($"o maior número é {maior} e o menor é {menor}");

// b) par ou impar
System.Console.WriteLine("digite um número para saber se é par ou ímpar: ");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    System.Console.WriteLine($"{num} é par");
}
else
{
    System.Console.WriteLine($"{num} é ímpar");
}

// c) positivo, negativo ou zero
System.Console.WriteLine("digite um número para saber se é positivo, negativo ou zero: ");
int valor = int.Parse(Console.ReadLine());

if (valor > 0)
{
    System.Console.WriteLine($"{valor} é positivo");
}
else if (valor < 0)
{
    System.Console.WriteLine($"{valor} é negativo");
}
else
{
    System.Console.WriteLine("o número é zero");
}
