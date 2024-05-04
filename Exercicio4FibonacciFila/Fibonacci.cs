namespace Exercicio4FibonacciFila
{
    internal class Fibonacci
    {
        int valor;
        Fibonacci? proximo;

        public Fibonacci(int valor)
        {
            this.valor = valor;
            this.proximo = null;
        }

        public void setNext(Fibonacci aux)
        {
            this.proximo = aux;
        }

        public Fibonacci? getNext()
        {
            return this.proximo;
        }

        public override string? ToString()
        {
            return $"{this.valor}";
        }
    }
}
