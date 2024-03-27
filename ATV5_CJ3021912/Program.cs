namespace ATV5_CJ3021912
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exercicio;
            Console.WriteLine("escolha o numero do exercicio de 1 a 7");
            exercicio = int.Parse(Console.ReadLine());
            switch (exercicio)
            {
                case 1:

                    //exercicio 1
                    Console.WriteLine("exercicio 1");
                    int num;
                    Console.WriteLine("insira um numero");
                    num = int.Parse(Console.ReadLine());
                    for (int i = 1; i >= 1 && i <= num; i++)
                    {
                        Console.WriteLine(i);
                        if (num < 1)
                        {
                            Console.WriteLine("este numero é negativo");
                            break;
                        }
                    }
                    break;

                    case 2:
                    //exercicio 2
                    Console.WriteLine("exercicio 2");
                    int num1;
                    Console.WriteLine("insira um numero");
                    num1 = int.Parse(Console.ReadLine());
                    for (int i = 1; i >= 1 && i <= num1; i++)
                    {
                        
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                        else
                        {
                            Console.WriteLine("este numero nao é par");
                        }
                    }break;

                    case 3:
                    //exercicico 3
                    Console.WriteLine("exercicio 3");
                    int num2;
                    Console.WriteLine("escreva um numero menor que 1000");
                    num2 = int.Parse(Console.ReadLine());
                    for(int i = 1;  i > 1000 || num2 > 1000; i++)
                    {
                        if (i % 2 == 0) {
                            Console.WriteLine(i);

                        }
                        else
                        {
                            Console.WriteLine("este numero nao é par");
                        }
                        


            }break;

        }
        }
    }


