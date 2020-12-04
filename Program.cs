using System;


namespace POOCelular
{
    class Program
    {   static void Main(string[] args)
        {
           
            Console.Clear();
            Celular Sunsung  = new Celular();

            Sunsung.cor = "preto";
            Sunsung.modelo = "J4 Prime +";
            Sunsung.tamanho = "7,5 x 15";
            Sunsung.ligado = true;

           Console.WriteLine("Deseja ligar o celular? S-Sim/ N-Não");
           string opcao = Console.ReadLine().ToLower();


            Inicio:

           if (opcao == "s")
           {
               Console.WriteLine("Escolha as opções: \n 1 - Fazer Ligação \n 2 - Enviar mensagem \n 3 - Sobre o celular \n 0 - Voltar");
               string menu = Console.ReadLine();

               switch (menu)
               {
                   case "1":
                   Console.WriteLine(Sunsung.ligar());
                       break;
                    case "2":
                    Console.WriteLine(Sunsung.enviarMensagem());
                        break;
                    case "3":
                    Console.WriteLine($"Marca Sunsung cor {Sunsung.cor} modelo {Sunsung.modelo} tamanho {Sunsung.tamanho}");
                        break;
                   default:
                   Console.WriteLine("Voltar para o menu anterior? S-Sim/N-Não");
                   string desejo=Console.ReadLine();
                   if (desejo == "sim")
                   {
                       goto Inicio; 
                          
                   }else{
                       Console.WriteLine("Continue interagindo!");
                   }
                       break;   
                       
                }
            
            }
            

           }
        }
    }

