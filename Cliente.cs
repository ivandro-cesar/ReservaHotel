using System;
using Newtonsoft.Json;

namespace Hotel{

    public class Cliente : Pessoa{
        
        public override void ExibirClientes(){
            base.ExibirClientes();
        }
        public static void CadastroCliente(Hotel hotel){
                    Console.Clear();
                    Console.WriteLine("Digite o nome do cliente:");
                    string nomeCliente = Console.ReadLine();
                    Console.WriteLine("\nDigite o CPF do cliente:");
                    string cpfCliente = Console.ReadLine();
                    Console.WriteLine("\nDigite o telefone do cliente:");
                    string numCliente = Console.ReadLine();
                    Cliente cliente = new Cliente{
                        _id = hotel.clientes.Count + 1,
                        _cpf = cpfCliente,
                        _nome = nomeCliente,
                        _telefone = numCliente              
                        };
                        hotel.clientes.Add(cliente);
                        SalvarDadosCliente(hotel);
                        Console.Clear();
                        Console.WriteLine("Cliente salvo com sucesso!");
                        Console.ReadLine();
        }
        public static void ConsultaClientes(Hotel hotel){
            for(int i=0;i < hotel.clientes.Count; i++){
                Console.Clear();
                Console.WriteLine("ID          Nome");    
                hotel.clientes.ForEach(obj => {
                    Console.Write($"{obj._id}          ");
                    Console.WriteLine($"{obj._nome}");
                });
                Console.ReadLine();
            }
        }
        public static void SalvarDadosCliente(Hotel hotel){
            Console.Clear();
            File.WriteAllText("clientes.json",  JsonConvert.SerializeObject(hotel.clientes));
        }
    }
}