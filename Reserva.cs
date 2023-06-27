using System;
using Newtonsoft.Json;
using ConsoleTables;

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
            int v = Int32.Parse(hotel.NullString(Console.ReadLine()));
            Console.WriteLine("Digite o CPF do cliente:");
            string cpf = hotel.NullString(Console.ReadLine());
            Console.WriteLine("\nDigite o número do quarto:");
            Quarto.ListarQuartos(hotel,v);
            int numQUarto = Int32.Parse(hotel.NullString(Console.ReadLine()));
            Console.WriteLine("\nDigite a quantidade de pessoas:");
            int qtdPessoas = Int32.Parse(hotel.NullString(Console.ReadLine()));
            Console.Clear();

            Console.WriteLine("\nPara qual ano deseja fazer o check-in?:");
            int ano = Int32.Parse(hotel.NullString(Console.ReadLine()));
            Console.WriteLine("\nSelecione o mês de check-in:");
            Console.WriteLine("\n1 - Janeiro\n2 - Fevereiro\n3 - Março\n4 - Abril\n5 - Maio\n6 - Junho\n7 - Julho\n8 - Agosto\n9 - Setembro\n10 - Outubro\n11 - Novembro\n12 - Dezembro");
            int mes = Int32.Parse(hotel.NullString(Console.ReadLine()));
            Console.WriteLine("\nSelecione o dia de check-in:");
            int dia = Int32.Parse(hotel.NullString(Console.ReadLine()));
            DateTime checkin = new DateTime(year: ano, month: mes, day: dia);
            Console.Clear();

            Console.WriteLine("\nPara qual ano deseja fazer o check-out?:");
            ano = Int32.Parse(hotel.NullString(Console.ReadLine()));
            Console.WriteLine("\nSelecione o mês de check-out:");
            Console.WriteLine("\n1 - Janeiro\n2 - Fevereiro\n3 - Março\n4 - Abril\n5 - Maio\n6 - Junho\n7 - Julho\n8 - Agosto\n9 - Setembro\n10 - Outubro\n11 - Novembro\n12 - Dezembro");
            mes = Int32.Parse(hotel.NullString(Console.ReadLine()));
            Console.WriteLine("\nSelecione o dia de check-out:");
            dia = Int32.Parse(hotel.NullString(Console.ReadLine()));
            DateTime checkout = new DateTime(year: ano, month: mes, day: dia);

            hotel.ReservarQuarto(cpf,numQUarto,qtdPessoas,checkin,checkout,v);
            
            SalvarDadosReserva(hotel);
            Quarto.SalvarDadosQuartos(hotel);
        }
        public static void SalvarDadosReserva(Hotel hotel){
            Console.Clear();
            File.WriteAllText("reservas.json",  JsonConvert.SerializeObject(hotel.reservas));
        }
        public static void ListarReservas(Hotel hotel){
            var table = new ConsoleTable("ID","N°Quarto","Cliente","Checkin","Checkout"); 
            Console.Clear(); 
            hotel.reservas.ForEach(obj => {
                table.AddRow(obj.Id, obj.NumQuarto, obj.Cliente.Nome, obj.Check_in.ToString("dd/MM/yy"), obj.Check_out.ToString("d/M/yy"));
            });
            table.Write();
        }
    }
}