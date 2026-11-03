int n, m, soma = 0;
double media ;

System.Console.WriteLine("digite o valor de n: ");
n = int.Parse(Console.ReadLine());
int [] v = new int [n];

for(int i=0;i<v.Length; i++)
{
    System.Console.WriteLine("digite o valor para colocar no vetor: ");
    m = int.Parse(Console.ReadLine());
    v[i] = m;
    soma += v[i];

}
media = (double)soma/v.Length;

System.Console.WriteLine($"o valor da soma é {soma}");
System.Console.WriteLine($"o valor da média é {media}");

