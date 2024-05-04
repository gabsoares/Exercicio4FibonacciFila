namespace Exercicio4FibonacciFila
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, anterior = 1, proximo, atual = -1;
            FilaFibonacci f1 = new();

            while (numero < 1)
            {
                Console.Write("Digite até qual termo da sequência de fibonacci deseja ver (digite número 1 ou maior): ");
                numero = int.Parse(Console.ReadLine());
                for (int i = 0; i < numero; i++)
                {
                    proximo = anterior + atual;
                    anterior = atual;
                    atual = proximo;
                    f1.Push(new(atual * -1));
                }
                f1.RunOver();
            }
        }
    }
}
