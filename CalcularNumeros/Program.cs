namespace calculo
{
    internal class Program
    {

        private static void Main(string[] args)
        {
            int n1, n2;
            string? TipoConta;


            Console.WriteLine("digite o primeiro numero:");
            n1 = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("digite o segundo numero");
            n2 = int.Parse(Console.ReadLine());

            CalcularNumeros(n1, n2);

        }

        private static void CalcularNumeros(int n1, int n2)
        {
            Console.Clear();
            Console.WriteLine("Escreva o tipo de conta que você que fazer(+, -, *, /)");
            var TipoConta = Console.ReadLine();

            var calculo = 0;

            if (TipoConta == "+")
            {
                Console.WriteLine($"O resultado da soma é {n1+n2}");
            }
            else if (TipoConta == "-")
            {
                Console.WriteLine($"O resultado da subtração é {n1-n2}");
            }
            else if (TipoConta == "*")
            {
                Console.WriteLine($"O resultado da multiplicação é {n1*n2}");
            }
            else if (TipoConta == "/")
            {
                Console.WriteLine($"O resultado da divisão é {n1/n2}");
            }
        }
    }
}