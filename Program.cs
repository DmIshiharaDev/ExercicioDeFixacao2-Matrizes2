internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Criando Matrizes");
        Console.WriteLine("----------------");

        Console.WriteLine();
        Console.Write("Digite o número de linhas que deseja: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Digite o número de colunas que deseja: ");
        int n = int.Parse(Console.ReadLine());

        int[,] mat = new int[m, n];

        for (int i = 0; i < m; i++)
        {
            Console.WriteLine();
            Console.WriteLine("Digite " + m + " valores inteiros com um espaço entre eles.");
            string[] values = Console.ReadLine().Split(' ');

            for (int j = 0; j < n; j++)
            {
                mat[i, j] = int.Parse(values[j]);
            }
        }

        Console.Write("Você quer a localização de qual número dentro da matriz? ");
        int x = int.Parse((string)Console.ReadLine());

       
        for ( int i = 0; i < m; ++i )
        {
            for (int j = 0; j < n; j++)
        }
    }
}