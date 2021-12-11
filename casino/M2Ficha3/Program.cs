using System;

namespace ficha3m2fevereiro
{
    class Program
    {
        static int saldo, opcao;
        

        static void Main(string[] args)
        {
            int idade;
            Console.WriteLine("Bem-vindo ao nosso cassino");
            System.Threading.Thread.Sleep(2000); //tempo de espera de 2.0s
            Console.Clear();//apagar no que esta na consola
            Console.WriteLine("A carregar os jogos...");
            System.Threading.Thread.Sleep(2000); //tempo de espera de 2.0s
            Console.Clear();//apagar no que esta na consola

            Console.WriteLine("Introduza a sua idade");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Podes utilizar o nosso cassino on-line");
                System.Threading.Thread.Sleep(2000); //tempo de espera de 2.0s
                Console.Clear();//apagar no que esta na consola

                Console.WriteLine("Insere o valor de euros que queres depositar no nosso cassino");
                saldo = int.Parse(Console.ReadLine());
                Console.Clear();//apagar no que esta na consola
                Menu1();
            }
            else if (idade <= 17)
                Console.WriteLine("És menor de idade não podes utilizar o nosso cassino, \n o programa vai ser encerrado");
            System.Threading.Thread.Sleep(2000); //tempo de espera de 2.0s
            Environment.Exit(0); //sair dirretamente da consola

        }

        private static void Menu1()
        {
            int a;
            Console.WriteLine("Escolha um dos seguintes jogos : \n 1 - Lotaria \n 2 - Raspadinha  \n 3 - Depositar dinheiro \n 4 - Retirar dinheiro \n 5 - Sair \n\n Saldo : " + saldo + " euros");
            a = int.Parse(Console.ReadLine());

            while (a != 0)
            {
                if (a == 1)
                {
                    Console.Clear(); //apagar no que esta na consola
                    Console.WriteLine("A carregar...");
                    System.Threading.Thread.Sleep(3000); //tempo de espera de 2.0s
                    Console.Clear();
                    lotaria();

                }
                else if (a == 2)
                {
                    Console.Clear(); //apagar no que esta na consola
                    Console.WriteLine("A carregar...");
                    System.Threading.Thread.Sleep(3000); //tempo de espera de 2.0s
                    Console.Clear();
                    raspadinhas();


                }
                else if (a == 3)
                {
                    Console.Clear(); //apagar no que esta na consola
                    Console.WriteLine("A carregar...");
                    System.Threading.Thread.Sleep(3000); //tempo de espera de 2.0s
                    Console.Clear(); //apagar no que esta na consola
                    depositar();

                }
                else if (a == 4)
                {
                    Console.Clear(); //apagar no que esta na consola
                    Console.WriteLine("A carregar...");
                    System.Threading.Thread.Sleep(3000); //tempo de espera de 2.0s
                    Console.Clear(); //apagar no que esta na consola
                    retirar();

                }
                else if (a == 5)
                {
                    Console.Clear(); //apagar no que esta na consola

                    Console.WriteLine("Deseja fechar o programa ?\n 1-Sim\n 2-Não"); // escrever as varias opções possiveis 
                    opcao = int.Parse(Console.ReadLine()); //armazenar na variavel opcao do tipo inteiro

                    if (opcao == 1)//se o valor for 1
                    {
                        Environment.Exit(0); //sair dirretamente da consola
                    }
                    else if (opcao == 2) //se o valor for 2
                    {
                        Console.Clear();//apagar no que esta na consola
                        Menu1();//ir para o menu 1 
                    }
                    else //caso as opçoes de cima n forem validas 
                    {

                        Console.WriteLine("Não existe este menu. Tente outro ");//imprimir se houver algum erro
                        System.Threading.Thread.Sleep(2000); //tempo de espera de 2.0s
                        Console.Clear();//apagar no que esta na consola
                        Menu1();//ir para o menu 1 
                    }
                    Console.Clear(); //apagar no que esta na consola 
                }
                /*else if (a >= 3 || a < -1)
                {
                    Console.WriteLine("Valor não respondido insira outro valor");
                    System.Threading.Thread.Sleep(3000); //tempo de espera de 2.5s
                    Console.Clear();
                    Menu1();

                }*/
                else //se todas as outras opçoes n forem executadas 
                {

                    Console.WriteLine("Não existe este menu. Tente outro ");//imprimir se houver algum erro
                    System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                    Console.Clear();//apagar no que esta na consola
                    Menu1(); //ir para o menu 1 

                }
            }
        }

        private static void lotaria()
        {


            int option, b;
            Console.WriteLine("Regras: \n · O numero tem de estar entre 1000 e 9999  \n · Jogue com cabeça e segurança\n · Não aposte dinheiro que precise \n Saldo: " + saldo + "\n Escolha o seu numero da sorte!");
            option = int.Parse(Console.ReadLine());

            Random r = new Random();
            double n1 = r.Next(1000, 9999);



            if (option > 9999 || option < 1000)
            {
                Console.Clear() ;
                Console.WriteLine("O teu numero não é valido o teu dinheiro não foi descontado");

                Console.WriteLine("\n 1 - Deseja jogar novamente ? \n 2 - Sair \n\n Saldo : " + saldo + " euros");
                b = int.Parse(Console.ReadLine());

                if (b == 1)
                {
                    Console.WriteLine("Deseja jogar outra vez ?");
                    Console.Clear();
                    lotaria();
                }
                else if (b == 2)
                {
                    Console.Clear(); //apagar no que esta na consola

                    Console.WriteLine("Deseja fechar o programa ?\n 1-Sim\n 2-Não"); // escrever as varias opções possiveis 
                    opcao = int.Parse(Console.ReadLine()); //armazenar na variavel opcao do tipo inteiro

                    if (opcao == 1)//se o valor for 1
                    {
                        Environment.Exit(0); //sair dirretamente da consola
                    }
                    else if (opcao == 2) //se o valor for 2
                    {
                        Console.Clear();//apagar no que esta na consola
                        Menu1();//ir para o menu 1 
                    }
                    else //caso as opçoes de cima n forem validas 
                    {

                        Console.WriteLine("Não existe este menu. Tente outro ");//imprimir se houver algum erro
                        System.Threading.Thread.Sleep(2000); //tempo de espera de 2.0s
                        Console.Clear();//apagar no que esta na consola
                        Menu1();//ir para o menu 1 
                    }
                    Console.Clear(); //apagar no que esta na consola 
                }
                else //caso as opçoes de cima n forem validas 
                {

                    Console.WriteLine("Não existe este menu. Tente outro ");//imprimir se houver algum erro
                    System.Threading.Thread.Sleep(2000); //tempo de espera de 2.0s
                    Console.Clear();//apagar no que esta na consola
                    Menu1();//ir para o menu 1 
                }
                Console.Clear(); //apagar no que esta na consola 



            }
            else if (option >= 1000 && option <= 9999)
            {

                if (option == n1)
                {
                    Console.WriteLine("A sortear o numero da sorte...");
                    System.Threading.Thread.Sleep(1000);//tempo de espera de 1.0s
                    Console.WriteLine("O numeor da sorte é " + n1);
                    Console.WriteLine("O teu numero foi " + option);
                    Console.WriteLine("Ganhas-te o premio máximo. Parabens!");
                    System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                    Console.Clear();//apagar no que esta na consola
                    menu2();
                }
                else if (n1 % 1000 == option % 1000)
                {
                    Console.WriteLine("Ganhas-te o segundo prémio");
                    Console.WriteLine("O numeor da sorte é " + n1);
                    Console.WriteLine("O teu numero foi " + option);
                    System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                    Console.Clear();//apagar no que esta na consola
                    menu2();
                }
                else if (n1 % 100 == option % 100)
                {
                    Console.WriteLine("Ganhas-te o terceiro prémio");
                    Console.WriteLine("O numeor da sorte é " + n1);
                    Console.WriteLine("O teu numero foi " + option);
                    System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                    Console.Clear();//apagar no que esta na consola
                    menu2();
                }
                else if (option != n1)
                {
                    Console.WriteLine("Infelizmente não ganhas-te o prémio");
                    Console.WriteLine("O numeor da sorte é " + n1);
                    Console.WriteLine("O teu numero foi " + option);
                    System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                    Console.Clear();//apagar no que esta na consola
                    menu2();
                }
                else
                {

                    Console.WriteLine("Houve um erro de codificação ");//imprimir se houver algum erro
                    System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                    Console.Clear();//apagar no que esta na consola
                    menu2(); //ir para lotaria 
                }


            }
            else //se todas as outras opçoes n forem executadas 
            {

                Console.WriteLine("Não existe este menu. Tente outro ");//imprimir se houver algum erro
                System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                Console.Clear();//apagar no que esta na consola
                menu2(); //ir para lotaria 

            }
            






        }
        public static void raspadinhas()
        {
            int raspadinhs;
            Console.WriteLine("Escolhe o tipo de raspadinhas que queres jogar ! \n 1 - Raspadinhas A \n 2 - Raspadinhas B");
            raspadinhs = int.Parse(Console.ReadLine());
            while(raspadinhs != 0)
            {
                if (raspadinhs == 1)
                {
                    Console.WriteLine("A carregar...");//imprimir se houver algum erro
                    System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                    Console.Clear();//apagar no que esta na consola
                    raspadinhastypea(); //ir para lotaria 
                }
                else if     (raspadinhs == 2)
                {
                    Console.WriteLine("A carregar...");//imprimir se houver algum erro
                    System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                    Console.Clear();//apagar no que esta na consola
                    raspadinhastypea(); //ir para lotaria 
                }
                else if (raspadinhs > 2 || raspadinhs < 1)
                {
                    Console.WriteLine("Não existe este menu. Tente outro ");//imprimir se houver algum erro
                    System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                    Console.Clear();//apagar no que esta na consola
                    Menu1(); //ir para lotaria 
                }
                else
                {
                    Console.WriteLine("Não existe este menu. Tente outro ");//imprimir se houver algum erro
                    System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                    Console.Clear();//apagar no que esta na consola
                    Menu1(); //ir para lotaria 
                }

            }



        }
        public static void raspadinhastypea()
        {
            int incremento= 0;
            Random s = new Random();
            int rasp = s.Next(1,10);

            Console.WriteLine("O teu numero da sorte é: " + rasp);

            for (int i = 0; i < 5; i++)
            {
                Random y = new Random();
                int rasp2 = y.Next(1, 10);
                Console.WriteLine(rasp2);
                if (rasp == rasp2)
                {
                    incremento++;
                }
            }
            Console.WriteLine("Incrementop" +incremento);

            if

        }
        public static void raspadinhastypeb()
        {

        }

        private static void menu2()
        {
            Console.Clear(); //apagar no que esta na consola
            int opcao3;
            Console.WriteLine("Deseja jogar outra vez? \n · 1 - Voltar a jogar \n · 2 - Sair");
            opcao3 = int.Parse(Console.ReadLine());


            if (opcao3 == 1)
            {
                Console.Clear();
                lotaria();
            }

            string opcao2;
            Console.WriteLine("Deseja fechar o programa ? (Sim/Não)"); // escrever as varias opções possiveis 
            opcao2 = Console.ReadLine(); //armazenar na variavel opcao do tipo inteiro



            if (opcao2 == "Sim")//se o valor for 1
            {
                Environment.Exit(0); //sair dirretamente da consola
            }
            else if (opcao2 == "Não") //se o valor for 2
            {
                Console.Clear();//apagar no que esta na consola
                Menu1();//ir para o menu 1 
            }
            else //caso as opçoes de cima n forem validas 
            {

                Console.WriteLine("Não existe este menu. Tente outro ");//imprimir se houver algum erro
                System.Threading.Thread.Sleep(2000); //tempo de espera de 2.0s
                Console.Clear();//apagar no que esta na consola
                Menu1();//ir para o menu 1 
            }
            Console.Clear(); //apagar no que esta na consola 
        }
        private static void depositar()
        {
            Console.WriteLine("Deseja depositar dinheiro ? \n 1· 100 euros \n 2· 500 euros \n 3· 2000 euros \n 4· Outro montante \n \n Saldo:" + saldo);
            int opdin, montante;
            opdin = int.Parse(Console.ReadLine());

            if (opdin == 1)
            {
                saldo += 100;
                Console.WriteLine("Transação com sucesso | 100 euros ");
                System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                Console.Clear();//apagar no que esta na consola
                Menu1();
            }
            else if (opdin == 2)
            {
                saldo += 500;
                Console.WriteLine("Transação com sucesso | 500 euros ");
                System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                Console.Clear();//apagar no que esta na consola
                Menu1();
            }
            else if (opdin == 3)
            {
                saldo += 2000;
                Console.WriteLine("Transação com sucesso | 2000 euros ");
                System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                Console.Clear();//apagar no que esta na consola
                Menu1();
            }
            else if (opdin == 4)
            {
                Console.Clear();
                Console.WriteLine("Escolha o valor do montande");
                montante = int.Parse(Console.ReadLine());

                saldo += montante;
                Console.WriteLine("Transação com sucesso | " + montante + " euros");
                System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                Console.Clear();//apagar no que esta na consola
                Menu1();

            }
            else
            {
                Console.WriteLine("Não existe este menu. Tente outro ");//imprimir se houver algum erro
                System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                Console.Clear();//apagar no que esta na consola
                menu2(); //ir para lotaria 
            }
        }
        private static void retirar()
        {
            Console.WriteLine("Deseja retirar dinheiro ? \n 1· 100 euros \n 2· 500 euros \n 3· 2000 euros \n 4· Outro montante \n ·Todo o dinheiro \n \n Saldo:" + saldo);
            int opdin, montante;
            opdin = int.Parse(Console.ReadLine());

            if (opdin == 1)
            {
                saldo -= 100;
                Console.WriteLine("Transação com sucesso | 100 euros ");
                System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                Console.Clear();//apagar no que esta na consola
                Menu1();
            }
            else if (opdin == 2)
            {
                saldo -= 500;
                Console.WriteLine("Transação com sucesso | 500 euros ");
                System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                Console.Clear();//apagar no que esta na consola
                Menu1();
            }
            else if (opdin == 3)
            {
                saldo -= 2000;
                Console.WriteLine("Transação com sucesso | 2000 euros ");
                System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                Console.Clear();//apagar no que esta na consola
                Menu1();
            }
            else if (opdin == 4)
            {
                Console.Clear();
                Console.WriteLine("Escolha o valor do montande");
                montante = int.Parse(Console.ReadLine());

                saldo -= montante;
                Console.WriteLine("Transação com sucesso | " + montante + " euros");
                System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                Console.Clear();//apagar no que esta na consola
                Menu1();

            }
            else if (opdin == 5)
            {
                saldo = 0;
                Console.WriteLine("Transação com sucesso o dinheiro foi todo retirado");
                System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                Console.Clear();//apagar no que esta na consola
                Menu1();
            }
            else
            {
                Console.WriteLine("Não existe este menu. Tente outro ");//imprimir se houver algum erro
                System.Threading.Thread.Sleep(2000);//tempo de espera de 2.0s
                Console.Clear();//apagar no que esta na consola
                menu2(); //ir para lotaria 
            }
        }

    }
}
