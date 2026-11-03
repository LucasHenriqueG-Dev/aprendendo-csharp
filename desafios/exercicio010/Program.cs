
int n,dezenas_jogadas,qnt_dezenas_jogadas, numeros_sorteados, acertos = 0;
int [] vMegaSena = new int [6];
int [] dezenas;

for(int i =0; i< vMegaSena.Length; i++)
{
    System.Console.WriteLine("digite os valores sorteados na Mega-Sena: ");
    numeros_sorteados = int.Parse(Console.ReadLine());
    vMegaSena[i] = numeros_sorteados;

}

System.Console.WriteLine("digite a quantidade de números jogados: ");
qnt_dezenas_jogadas = int.Parse(Console.ReadLine());
dezenas  = new int[qnt_dezenas_jogadas];

for(int i =0; i<qnt_dezenas_jogadas; i++)
{
    System.Console.WriteLine("digite os números apostados: ");
    dezenas_jogadas = int.Parse(Console.ReadLine());
    dezenas[i] = dezenas_jogadas; 
}

for(int i = 0; i<vMegaSena.Length; i++)
{
    for(int j = 0; j < dezenas.Length; j++)
    {
        if (vMegaSena[i] == dezenas[j])
        {
            acertos++;
        }
        
    }

}

for(int i =0; i<dezenas.Length ; i++)
{
    System.Console.Write(dezenas[i]);
}
for(int i =0; i<vMegaSena.Length ; i++)
{
    System.Console.Write(vMegaSena[i]);
}
System.Console.WriteLine($"você teve {acertos} acertos");