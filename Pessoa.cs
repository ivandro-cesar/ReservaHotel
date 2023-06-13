using System;
using Newtonsoft.Json;

namespace Hotel{

    public abstract class Pessoa: IPessoa{
        public string _cpf;
        public string _nome;
        public int _id;
        public string _telefone{get;set;}

        public virtual void ExibirClientes(){
            Console.WriteLine($"CPF: {_cpf}, nome: {_nome}");
        }

        public string getCpf(){
            return _cpf;
        }
        public string getNome(){
            return _nome;
        }
        public static void CadastroCliente(Hotel hotel){
                    Console.WriteLine("Digite o nome do cliente:");
                    string nomeCliente = Console.ReadLine();
                    Console.WriteLine("Digite o CPF do cliente:");
                    string cpfCliente = Console.ReadLine();
                    Console.WriteLine("Digite o telefone do cliente:");
                    string numCliente = Console.ReadLine();
                    Cliente cliente = new Cliente{
                        _id = hotel.clientes.Count + 1,
                        _cpf = cpfCliente,
                        _nome = nomeCliente,
                        _telefone = numCliente              
                        };
                        hotel.clientes.Add(cliente);
                        SalvarDadosCliente(hotel);
        }
        public static void SalvarDadosCliente(Hotel hotel){
            File.WriteAllText("clientes.json",  JsonConvert.SerializeObject(hotel.clientes));
        }
    }
}