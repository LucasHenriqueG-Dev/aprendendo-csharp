class Program{

 static int soma_positivos(int n){
        int soma =0 ;
        for(int i = 1; i<n; i++)
        {
            soma+=i;
        }
        return soma;

 }

  static int soma_positivos_pares(int n){
        int soma_p =0 ;
        for(int i = 1; i<n; i++)
        {
            soma+=i;
        }
        return soma;

 }


    static void Main(string[] args)
    {
        int n;
        System.Console.WriteLine("diga o numero que vc deseja saber a soma dos antecessores: ");
        n = int.Parse(Console.ReadLine());

        System.Console.WriteLine($"a soma dos {n} primeiros inteiros positivos é: {soma_positivos(n)}");

    }
}