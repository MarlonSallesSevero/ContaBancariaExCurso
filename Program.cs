using System;

namespace ContaBancaria
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numConta,opera = 0,contr;
            string nome;
            double vl;
            ContaBancaria a;
            Console.WriteLine("Informe o numero da conta:");
            numConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do titular da conta:");
            nome = Console.ReadLine();
            a = new ContaBancaria(numConta, nome);

            Console.WriteLine("*------------------------------*");

            Console.WriteLine("Deseja realizar um deposito inicial?\n1-SIM\n2-NAO");
            contr = int.Parse(Console.ReadLine());
            if (contr == 1)
            {
                Console.WriteLine("Informe o valor a depositar");
                vl = double.Parse(Console.ReadLine());
                a.Deposito(vl);
                Console.WriteLine($"{a.Nconta}:{a.Nome}:{a.Saldo}\n*------------------------------*");
            }
            else if (contr == 2)
            {
                Console.WriteLine("ok!!");
                Console.WriteLine($"{a.Nconta}:{a.Nome}:{a.Saldo}\n*------------------------------*");
            }
            else
            {
                Console.WriteLine("Operacao Invalida!!");
                Console.WriteLine($"{a.Nconta}:{a.Nome}:{a.Saldo}\n*------------------------------*");
            }
            while (opera != 2) {
                Console.WriteLine("Informe uma operacao:");
                Console.WriteLine("1-DEPOSITO\n2-SAQUE");
                opera = int.Parse(Console.ReadLine());
                if(opera == 1)
                {
                    Console.WriteLine("Informe o valor a depositar:");
                    vl = double.Parse(Console.ReadLine());
                    a.Deposito(vl);
                    Console.WriteLine($"{a.Nconta}:{a.Nome}:{a.Saldo}\n*------------------------------*");
                }
                else if (opera == 2)
                {
                    Console.WriteLine("Informe o valor a Sacar:");
                    vl = double.Parse(Console.ReadLine());
                    a.Saque(vl);
                    Console.WriteLine($"{a.Nconta}:{a.Nome}:{a.Saldo}\n*------------------------------*");
                }
                else
                {
                    Console.WriteLine("Opcao Invalida!!\n*------------------------------*");
                }
                Console.WriteLine("Quer Continuar?\n1-SIM\n2-NAO");
                opera = int.Parse(Console.ReadLine());
                Console.WriteLine("*------------------------------*");
            }
        }
    }
}
