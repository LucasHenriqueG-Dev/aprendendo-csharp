int n, voto, branco = 0, nulos = 0;
string [] nomes;
int [] numero;
int [] idade;
int [] votos;

System.Console.WriteLine("digite o número de candidatos entre 5 e 10: ");
n = int.Parse(Console.ReadLine());

while (n < 5 || n > 10){
    System.Console.WriteLine("digite o número de candidatos entre 5 e 10: ");
    n = int.Parse(Console.ReadLine());
}

// os vetores sao criados uma vez so, depois de saber o n
nomes = new string [n];
numero = new int [n];
idade = new int [n];
votos = new int [n];

for(int i = 0; i<n; i++){
    System.Console.WriteLine($"digite o nome do candidato {i+1}/{n}: ");
    nomes[i]= Console.ReadLine();
    System.Console.WriteLine($"digite o número do candidato {i+1}/{n}: ");
    numero[i]= int.Parse(Console.ReadLine());
    System.Console.WriteLine($"digite a idade do candidato {i+1}/{n}: ");
    idade[i]= int.Parse(Console.ReadLine());
}

// cada um dos n eleitores vota pelo numero do candidato (0 = branco)
for(int i = 0; i < n ; i++){
    System.Console.WriteLine($"eleitor {i+1}/{n}, digite o número do seu candidato (0 para branco): ");
    voto = int.Parse(Console.ReadLine());

    if (voto == 0)
    {
        branco++;
    }
    else
    {
        bool achou = false;
        for(int j = 0; j < n; j++)
        {
            if (numero[j] == voto)
            {
                votos[j]++;
                achou = true;
            }
        }
        if (!achou)
        {
            nulos++;
        }
    }
}

// vencedor: mais votos, no empate ganha o mais velho
int vencedor = 0;
for(int i = 1; i < n; i++)
{
    if (votos[i] > votos[vencedor])
    {
        vencedor = i;
    }
    else if (votos[i] == votos[vencedor] && idade[i] > idade[vencedor])
    {
        vencedor = i;
    }
}

System.Console.WriteLine("resultado:");
for(int i = 0; i < n; i++)
{
    System.Console.WriteLine($"{nomes[i]} ({numero[i]}) - {votos[i]} votos");
}
System.Console.WriteLine($"brancos: {branco}");
System.Console.WriteLine($"nulos: {nulos}");
System.Console.WriteLine($"o vencedor é {nomes[vencedor]} com {votos[vencedor]} votos");
