using System;
using System.Collections;
using System.Diagnostics;

class Program
{
    //funcao  para voltar
/* static void Voltar()
    {
        Console.WriteLine("Qual dessas operações você quer?");
        Console.WriteLine("1 - Calculadora");
        Console.WriteLine("2 - Anotações");
        Console.WriteLine("3 - Vou pensar");
        Console.WriteLine("4 - Sair");

        int escolha = Convert.ToInt32(Console.ReadLine());
        //Tentar criar um método para voltar ao começo do menu de operação ;-)
        //tentar criar outro metodo com o mesmo switch e depois chamar la embaixo, é uma gambiarra mas deve funcionar
        switch (escolha)
        {
            case 1:
                Console.WriteLine("Qual dessas operações você quer?");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Voltar");


                int escolhacalc = Convert.ToInt32(Console.ReadLine());
                double n1, n2, resultado = 0;
                switch (escolhacalc)
                {
                    case 1:
                        Console.WriteLine("Adição");
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Digite um numero:");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite outro numero:");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        resultado = n1 + n2;
                        Console.WriteLine(resultado);

                        break;
                    case 2:
                        Console.WriteLine("Subtração");
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Digite um numero:");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite outro numero:");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        resultado = n1 - n2;
                        Console.WriteLine(resultado);

                        break;
                    case 3:
                        Console.WriteLine("Multiplicação");
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Digite um numero:");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite outro numero:");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        resultado = n1 * n2;
                        Console.WriteLine(resultado);

                        break;
                    case 4:
                        Console.WriteLine("DIvisão");
                        Console.WriteLine("-----------------------");
                        Console.WriteLine("Digite um numero:");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Digite outro numero:");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        resultado = n1 / n2;
                        Console.WriteLine(resultado);
                        break;
                    case 5:
                        Voltar();
                        break;


                }
                Console.WriteLine("Deseja continuar realizando contas? (S/N): ");
                string continuar = Console.ReadLine();
                if (continuar == "N")
                {
                    Console.WriteLine("Encerrando o programa. Até mais!");
                    break;
                }
                else
                {
                    Verificar();
                }
                break;

        }*/
        static void Perguntar(){
            
            
             Console.WriteLine("Deseja continuar realizando contas? (S/N): ");
                string continuar = Console.ReadLine();
                
                switch(continuar){
                     case "N":
                     Console.WriteLine("Encerrando o programa. Até mais!");
                     break;

                     case "S":
                         Verificar();
                     break;
                }              
                
                
        }
        //função para verificar 
        static void Verificar()
        {
            Console.WriteLine("Qual dessas operações você quer?");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Voltar");
            int escolha = Convert.ToInt32(Console.ReadLine());
            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Adição");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Digite um numero:");
                    int n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite outro numero:");
                    int n2 = Convert.ToInt32(Console.ReadLine());
                    int resultado = n1 + n2;
                    Console.WriteLine(" O resultado é: " +resultado);

                    break;
                case 2:
                    Console.WriteLine("Subtração");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Digite um numero:");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite outro numero:");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    resultado = n1 - n2;
                    Console.WriteLine(" O resultado é: " +resultado);

                    break;
                case 3:
                    Console.WriteLine("Multiplicação");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Digite um numero:");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite outro numero:");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    resultado = n1 * n2;
                    Console.WriteLine( " O resultado é: " +resultado);

                    break;
                case 4:
                    Console.WriteLine("DIvisão");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Digite um numero:");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite outro numero:");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    resultado = n1 / n2;
                    Console.WriteLine(" O resultado é: " +resultado);
                    break;
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Qual dessas opções você quer?");
            Console.WriteLine("1 - Calculadora");
            Console.WriteLine("2 - Anotações");
            Console.WriteLine("3 - Vou pensar");
            Console.WriteLine("4 - Sair");

            int escolha = Convert.ToInt32(Console.ReadLine());
              
          switch (escolha)
          
          
          //Tentar criar um método para voltar ao começo do menu de operação ;-
          //tentar criar outro metodo com o mesmo switch e depois chamar la embaixo, é uma gambiarra mas deve funcionar

            {
                case 1:
                    Console.WriteLine("Qual dessas operações você quer?");
                    Console.WriteLine("1 - Adição");
                    Console.WriteLine("2 - Subtração");
                    Console.WriteLine("3 - Multiplicação");
                    Console.WriteLine("4 - Divisão");



                    int escolhacalc = Convert.ToInt32(Console.ReadLine());
                    double n1, n2, resultado = 0;
                    switch (escolhacalc)
                    {
                        case 1:
                            Console.WriteLine("Adição");
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("Digite um numero:");
                            n1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite outro numero:");
                            n2 = Convert.ToInt32(Console.ReadLine());
                            resultado = n1 + n2;
                            Console.WriteLine(" O resultado é: " +resultado);

                            break;
                        case 2:
                            Console.WriteLine("Subtração");
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("Digite um numero:");
                            n1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite outro numero:");
                            n2 = Convert.ToInt32(Console.ReadLine());
                            resultado = n1 - n2;
                            Console.WriteLine(" O resultado é: " +resultado);

                            break;
                        case 3:
                            Console.WriteLine("Multiplicação");
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("Digite um numero:");
                            n1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite outro numero:");
                            n2 = Convert.ToInt32(Console.ReadLine());
                            resultado = n1 * n2;
                            Console.WriteLine(" O resultado é: " +resultado);

                            break;
                        case 4:
                            Console.WriteLine("DIvisão");
                            Console.WriteLine("-----------------------");
                            Console.WriteLine("Digite um numero:");
                            n1 = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Digite outro numero:");
                            n2 = Convert.ToInt32(Console.ReadLine());
                            resultado = n1 / n2;
                            Console.WriteLine(" O resultado é: " +resultado);
                            break;
                       

                        
                    }
                   Perguntar();
                   break;
                    case 2: 
              
                    break;

                    case 3: 
                    
                    break;

                    case 4:
                    Console.WriteLine("Saindo! Até mais!");
                    break;
            }
        }
}


