using System;
using Newtonsoft.Json;

namespace Hotel{

    public class Cliente : Pessoa{

        public Cliente(int id,string cpf, string nome, string telefone){
            Id = id;
            Cpf = cpf;
            Nome = nome;
            Telefone = telefone;
        }
        
        public override void ExibirPessoas(){
            base.ExibirPessoas();
        }
        public static void CadastroCliente(Hotel hotel){
                    Console.Clear();
                    Console.WriteLine("Digite o nome do cliente:");
                    string nomeCliente = Console.ReadLine();
                    Console.WriteLine("\nDigite o CPF do cliente:");
                    string cpfCliente = Console.ReadLine();
                    Console.WriteLine("\nDigite o telefone do cliente:");
                    string numCliente = Console.ReadLine();
                    Cliente cliente = new Cliente(hotel.clientes.Count + 1,cpfCliente,nomeCliente,numCliente);
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
                    Console.Write($"{obj.Id}          ");
                    Console.WriteLine($"{obj.Nome}");
                });
            }
            Console.ReadLine();
        }
        public static void SalvarDadosCliente(Hotel hotel){
            Console.Clear();
            File.WriteAllText("clientes.json",  JsonConvert.SerializeObject(hotel.clientes));
        }
    }
}