Console.WriteLine("digite o número de empregados da loja: ");
int empregados = int.Parse(Console.ReadLine());

Console.WriteLine("digite o valor do salário mínimo: ");
double salario_min = double.Parse(Console.ReadLine());

Console.WriteLine("digite o preço de custo de cada bicicleta: ");
double custo_bicicleta = double.Parse(Console.ReadLine());

Console.WriteLine("digite o número de bicicletas vendidas: ");
int bicicletas_vendidas = int.Parse(Console.ReadLine());

//valor q cada empregado recebe

double valor_bicicleta = custo_bicicleta * 1.5;

double comissao = custo_bicicleta* bicicletas_vendidas* 0.15;

double comissao_empregado = comissao / empregados;

double salario_final = (2 * salario_min) + comissao_empregado;

double despesas = salario_final * empregados + custo_bicicleta * bicicletas_vendidas;


Console.WriteLine("o valor final a ser pago para cada funcionário é de: R$"+ salario_final);

double receita = bicicletas_vendidas * valor_bicicleta;
double total = receita - despesas;
if(total >0){
    Console.WriteLine("a receita final da loja é de: R$"+ total);
}
else if(total == 0)
{
    Console.WriteLine("a loja não teve lucro nem prejuízo");
}
else
{
    Console.WriteLine("o prejuízo foi de: R$"+ total);
}

