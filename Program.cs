using System;

namespace Hotel{
    class Program{

        static void Main(string[] args){
            
            int opcao;

                do{
                    Console.Clear();
                    Console.WriteLine("----| Bem vindo ao Hotel |----");
                    Console.WriteLine("Selecione a opção desejada:");
                    Console.WriteLine("1 - Cadastrar cliente");
                    Console.WriteLine("2 - Consultar cliente");
                    Console.WriteLine("3 - Criar reserva");
                    Console.WriteLine("4 - Consultar reserva");
                    Console.WriteLine("0 - Encerrar");

                    int.TryParse(Console.ReadLine(), out opcao);

                    switch(opcao){
                        case 1:

                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                        case 4:

                            break;
                        case 0:

                            break;
                    }
                }while(opcao!=0);
        }
    }
}