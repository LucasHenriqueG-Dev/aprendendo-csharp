using System.Diagnostics.Contracts;

System.Console.WriteLine("digite o valor da herança: ");
double herança = double.Parse(Console.ReadLine());

System.Console.WriteLine("digite a idade do primeiro irmão: ");
int idade1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("digite a idade do segundo irmão: ");
int idade2 = int.Parse(Console.ReadLine());

System.Console.WriteLine("digite a idade do terceiro irmão: ");
int idade3 = int.Parse(Console.ReadLine());

int soma_idades = idade1 + idade2 + idade3;

double fatia = herança/soma_idades;

System.Console.WriteLine("o valor que o irmão cuja idade é "+ idade1 + " vai receber: R$"+ fatia*idade1);
System.Console.WriteLine("o valor que o irmão cuja idade é "+ idade2 + " vai receber: R$"+ fatia*idade2);
System.Console.WriteLine("o valor que o irmão cuja idade é "+ idade3 + " vai receber: R$"+ fatia*idade3);
