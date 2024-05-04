namespace Exercicio4FibonacciFila
{
    internal class FilaFibonacci
    {
        Fibonacci? head, tail;

        public FilaFibonacci()
        {
            this.head = null;
            this.tail = null;
        }

        public void Push(Fibonacci aux)
        {
            if (IsEmpty())
            {
                head = tail = aux;
            }
            else
            {
                this.tail.setNext(aux);
                this.tail = aux;
            }
        }

        public void RunOver()
        {
            Fibonacci aux = this.head;
            if (!IsEmpty())
            {
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.getNext();
                } while (aux != null);
            }
        }

        public bool IsEmpty()
        {
            return head == null && tail == null;
        }
    }
}
