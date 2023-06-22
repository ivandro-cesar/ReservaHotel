using System;
using Newtonsoft.Json;

namespace Hotel{
    public class Reserva{

        public int Id {get;private set;}
        public Cliente Cliente{get;private set;}
        public int NumQuarto{get;private set;}
        public int QntPessoas{get;private set;}
        public DateTime Check_in{get;private set;}
        public DateTime Check_out{get;private set;}

        public Reserva(int id,Cliente cliente,int numQuarto, int qtdPessoas, DateTime check_in, DateTime check_out){
            Id = id;
            Cliente = cliente;
            NumQuarto = numQuarto;
            QntPessoas = qtdPessoas;
            Check_in = check_in;
            Check_out = check_out;
        }

        public static void CriaReserva(Hotel hotel){
            Console.Clear();
            Console.WriteLine("Qual tipo de quarto deseja reservar?");
            Console.WriteLine("1 - Quarto padrão");
            Console.WriteLine("2 - Quarto luxo");
            Console.WriteLine("3 - Quarto master");
            Console.WriteLine("0 - Voltar");
            int v = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digite o CPF do cliente:");
            string cpf = Console.ReadLine();
            Console.WriteLine("\nDigite o número do quarto:");
            int numQUarto = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite a quantidade de pessoas:");
            int qtdPessoas = Int32.Parse(Console.ReadLine());
            hotel.ReservarQuarto(cpf,numQUarto,qtdPessoas,v);
            
            SalvarDadosReserva(hotel);
            Quarto.SalvarDadosQuartos(hotel);
            Console.ReadLine();
        }
        public static void SalvarDadosReserva(Hotel hotel){
            Console.Clear();
            File.WriteAllText("reservas.json",  JsonConvert.SerializeObject(hotel.reservas));
        }
        public static void ListarReservas(Hotel hotel){
            for(int i=0;i < hotel.reservas.Count; i++){
                Console.Clear();
                Console.WriteLine("ID        N°Quarto          Cliente");    
                hotel.reservas.ForEach(obj => {
                    Console.Write($"{obj.Id}              ");
                    Console.Write($"{obj.NumQuarto}            ");
                    Console.WriteLine($"{obj.Cliente.Nome}");
                });
            }
        }
    }
}