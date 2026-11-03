
class Program
{
    static void Main()
    {
        int dias, dia_maior_media = 0, dia_menor_media = 0;
        double consumo_final = 0, media, maior_consumo, menor_consumo;
        
        double[] energia_dia;
        double[] energia_dia_simulado;

        do
        {
            Console.Write("Digite a quantidade de dias (deve estar entre 7 e 30 dias): ");
            if (!int.TryParse(Console.ReadLine(), out dias))
            {
                dias = 0; 
            }

        } while (dias < 7 || dias > 30);

        energia_dia = new double[dias];
        energia_dia_simulado = new double[dias];

        Console.WriteLine("Entrada de Dados de Consumo");
        for (int i = 0; i < energia_dia.Length; i++)
        {
            double valor_kwh;
            do
            {
                Console.Write($"Digite o valor do KWh do dia {i + 1}: ");
                if (!double.TryParse(Console.ReadLine(), out valor_kwh))
                {
                    valor_kwh = -1; 
                }
                if (valor_kwh < 0)
                {
                    Console.WriteLine("Valor inválido! O consumo não pode ser negativo.");
                }
            } while (valor_kwh < 0);
            
            energia_dia[i] = valor_kwh;
        }

        Console.WriteLine("Relatório de Consumo Diário");
        for (int i = 0; i < energia_dia.Length; i++)
        {
            Console.WriteLine($"Dia {i + 1}: {energia_dia[i]:F2} kWh");
            consumo_final += energia_dia[i];
        }

        Console.WriteLine($"Consumo total do período: {consumo_final:F2} kWh");

        media = consumo_final / energia_dia.Length;
        Console.WriteLine($"Consumo médio diário: {media:F2} kWh");

        maior_consumo = energia_dia[0];
        menor_consumo = energia_dia[0];

        for (int i = 1; i < energia_dia.Length; i++)
        {
            if (energia_dia[i] > maior_consumo)
            {
                maior_consumo = energia_dia[i];
            }
            if (energia_dia[i] < menor_consumo)
            {
                menor_consumo = energia_dia[i];
            }
        }

        Console.Write($"O maior consumo registrado foi de {maior_consumo:F2} kWh, ocorrendo no(s) dia(s): ");
        for (int i = 0; i < energia_dia.Length; i++)
        {
            if (energia_dia[i] == maior_consumo)
            {
                Console.Write((i + 1) + " ");
            }
        }
        Console.WriteLine();

        Console.Write($"O menor consumo registrado foi de {menor_consumo:F2} kWh, ocorrendo no(s) dia(s): ");
        for (int i = 0; i < energia_dia.Length; i++)
        {
            if (energia_dia[i] == menor_consumo)
            {
                Console.Write((i + 1) + " ");
            }
        }
        Console.WriteLine();

        for (int i = 0; i < energia_dia.Length; i++)
        {
            if (energia_dia[i] > media)
            {
                dia_maior_media++;
            }
            else if (energia_dia[i] < media)
            {
                dia_menor_media++;
            }
        }
        Console.WriteLine($"Quantidade de dias com consumo ACIMA da média: {dia_maior_media}");
        Console.WriteLine($"Quantidade de dias com consumo ABAIXO da média: {dia_menor_media}");

        Console.WriteLine("Classificação do Consumo");
        for (int i = 0; i < energia_dia.Length; i++)
        {
            Console.Write($"Dia {i + 1} ({energia_dia[i]:F2} kWh): ");
            if (energia_dia[i] < 0.8 * media)
            {
                Console.WriteLine("Baixo consumo");
            }
            else if (energia_dia[i] <= 1.2 * media)
            {
                Console.WriteLine("Consumo normal");
            }
            else
            {
                Console.WriteLine("Alto consumo");
            }
        }

        Console.WriteLine("Simulação de Política de Economia");
        double percentualReducao;
        do
        {
            Console.Write("Informe o percentual de redução esperado para dias de ALTO consumo (maior que 0 e até 50%): ");
            if (!double.TryParse(Console.ReadLine(), out percentualReducao))
            {
                percentualReducao = 0;
            }
        } while (percentualReducao <= 0 || percentualReducao > 50);

        double fatorReducao = 1 - (percentualReducao / 100);
        double novoConsumoTotal = 0;

        for (int i = 0; i < energia_dia.Length; i++)
        {
            if (energia_dia[i] > 1.2 * media) 
            {
                energia_dia_simulado[i] = energia_dia[i] * fatorReducao;
            }
            else
            {
                energia_dia_simulado[i] = energia_dia[i]; 
            }
            novoConsumoTotal += energia_dia_simulado[i];
        }

        Console.WriteLine("Resultados da Simulação");
        
        for (int i = 0; i < energia_dia_simulado.Length; i++)
        {
            Console.WriteLine($"Dia {i + 1}: Novo consumo = {energia_dia_simulado[i]:F2} kWh");
        }

        Console.WriteLine($"Novo consumo total do período: {novoConsumoTotal:F2} kWh");

        double kwhEconomizados = consumo_final - novoConsumoTotal;
        Console.WriteLine($"Quantidade total de kWh economizados: {kwhEconomizados:F2} kWh");

        double percentualRealObtido = (kwhEconomizados / consumo_final) * 100;
        Console.WriteLine($"Percentual de redução real obtido sobre o total original: {percentualRealObtido:F2}%");
    }
}
