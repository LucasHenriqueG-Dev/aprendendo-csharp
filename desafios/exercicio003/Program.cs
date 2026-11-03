using System.Data.Common;
using System.Runtime.InteropServices;
using System.Xml;

System.Console.WriteLine("digite o primeiro número: ");
double num1 = double.Parse(Console.ReadLine());

System.Console.WriteLine("digite o segundo número: ");
double num2 = double.Parse(Console.ReadLine());

int opc = 1;
while(opc != 0)
{
    System.Console.WriteLine("digite 1 para fazer conta de soma");
    System.Console.WriteLine("digite 2 para fazer conta de subtração");
    System.Console.WriteLine("digite 3 para fazer conta de divisão");
    System.Console.WriteLine("digite 4 para fazer conta de multiplicação");
    System.Console.WriteLine("digite 0 para encerrar");
    opc = int.Parse(Console.ReadLine());

    if (opc == 1)
    {
        double soma = num1 + num2;
        System.Console.WriteLine("a soma dos dois números é igual a: "+ soma);
        
    }
    else if (opc == 2)
    {
        double sub = num1 - num2;
        System.Console.WriteLine("a subtração dos dois números é igual a: "+ sub);
        
    }
    else if (opc == 3)
    {
        if (num2 == 0)
        {
            System.Console.WriteLine("não é possível dividir por zero");
        }
        else
        {
            double div = num1/num2;
            System.Console.WriteLine("a divisão dos dois números é igual a: "+ div);
        }


    }
    else if (opc== 4)
    {
        double mul = num1 * num2;
        System.Console.WriteLine("a multiplicação dos dois números é igual a: "+ mul);
        
    }
    else if  (opc == 0)
    {
        System.Console.WriteLine("obrigado por usar");
        break;
    }
    else 
    {
        System.Console.WriteLine("erro, digite outro valor");
        
    } 
}