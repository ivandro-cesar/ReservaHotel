using System;
using Newtonsoft.Json;

namespace Hotel{
    public class Reserva{

        public int Id;
        public string CpfCliente;
        public string NomeCLiente;
        public int NumQuarto;
        public int QntPessoas;
        public DateTime Check_in;
        public DateTime Check_out;


        public static void CriaReserva(Hotel hotel){
            Console.Clear();
            Console.WriteLine("Digite o CPF do cliente:");
            string cpf = Console.ReadLine();
            Console.WriteLine("\nDigite o número do quarto:");
            int numQUarto = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite a quantidade de pessoas:");
            int qtdPessoas = Int32.Parse(Console.ReadLine());
            hotel.ReservarQuarto(cpf,numQUarto,qtdPessoas);
            
            SalvarDadosReserva(hotel);
            Quarto.SalvarDadosQuartos(hotel);
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
                    Console.WriteLine($"{obj.NomeCLiente}");
                });
            }
        }
    }
}