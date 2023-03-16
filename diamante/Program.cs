namespace diamante
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" Digite um número ímpar: ");
            int numero = int.Parse(Console.ReadLine());
            int espaco = numero - 1;
            int letra = 1;

            if ( numero % 2 == 0)
            {              
                Console.WriteLine("O número não é ímpar");
                Console.ReadLine();
            }

            else

            for (int i = 0; i < numero; i++)
            {

                for (int j = 0; j < espaco; j++) 
                {
                    Console.Write(" ");
                }

                for (int k = 0; k < letra; k++)
                {
                    Console.Write("X");
                }
               
                Console.WriteLine();

                if (i < (numero / 2))
                {
                    espaco--;
                    letra += 2;
                }
                else
                {
                    espaco++;
                    letra -= 2;
                }
                

                Console.ReadLine();
            }
        }   
    }
}



















