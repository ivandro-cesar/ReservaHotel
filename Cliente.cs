using System;
using Newtonsoft.Json;
using ConsoleTables;

namespace Hotel{

    public class Cliente : Pessoa{
        public Cliente(int id, string cpf, string nome, string telefone) : base(id, cpf, nome, telefone){}

        public override void ExibirPessoas(){
            base.ExibirPessoas();
        }
        public static void CadastroCliente(Hotel hotel){
                    Console.Clear();
                    Console.WriteLine("Digite o nome do cliente:");
                    string nomeCliente = hotel.NullString(Console.ReadLine());
                    Console.WriteLine("\nDigite o CPF do cliente:");
                    string cpfCliente = hotel.NullString(Console.ReadLine());
                    Console.WriteLine("\nDigite o telefone do cliente:");
                    string numCliente = hotel.NullString(Console.ReadLine());
                    Cliente cliente = new Cliente(hotel.clientes.Last().Id + 1,cpfCliente,nomeCliente,numCliente);
                    hotel.clientes.Add(cliente);
                    SalvarDadosCliente(hotel);
                    Console.Clear();
                    Console.WriteLine("Cliente salvo com sucesso!");
                    Console.ReadLine();
        }
        public static void ConsultaClientes(Hotel hotel){
            var table = new ConsoleTable("Id","Nome","CPF"); 
            Console.Clear();
            hotel.clientes.ForEach(obj => {
                table.AddRow(obj.Id, obj.Nome, obj.Cpf);
            });
            table.Write();
            Console.ReadLine();
        }
        public static void SalvarDadosCliente(Hotel hotel){
            Console.Clear();
            File.WriteAllText("clientes.json",  JsonConvert.SerializeObject(hotel.clientes));
        }
    }
}