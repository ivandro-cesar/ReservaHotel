using System;
using Newtonsoft.Json;

namespace Hotel{

    public class Hotel{
        public List<Cliente> clientes = new List<Cliente>();
        public List<QuartoPadrao> quartosPadrao = new List<QuartoPadrao>();
        public List<QuartoLuxo> quartosLuxo = new List<QuartoLuxo>();
        public List<QuartoMaster> quartosMaster = new List<QuartoMaster>();
        public List<Reserva> reservas = new List<Reserva>();

        public void ReservarQuarto(string cpfCliente, int numQuarto, int qtdPessoas){
            try{
                QuartoLuxo quartoLuxo = quartosLuxo.Find(q => q.getNum() == numQuarto && q.getDisponivel() == true);
                
                if(quartoLuxo == null){
                    Console.Clear();
                    Console.WriteLine("Quarto não encontrado ou indisponível!");
                    Console.ReadLine();
                    return;
                }

                Cliente cliente = clientes.Find(c => c.getCpf() == cpfCliente);

                if(cliente == null){
                    Console.Clear();
                    Console.WriteLine("Cliente não encontrado!");
                    Console.ReadLine();
                    return;
                }
                
                if(qtdPessoas > quartoLuxo._maxPessoas){
                    Console.Clear();
                    Console.WriteLine("Quantidade de pessoas acima da permitida para esse quarto!");
                    Console.ReadLine();
                    return;
                }

                Reserva reserva = new Reserva{
                    Id = reservas.Count + 1,
                    CpfCliente = cliente._cpf,
                    NomeCLiente = cliente._nome,
                    NumQuarto = quartoLuxo._numero,
                    QntPessoas = qtdPessoas,
                    Check_in = new DateTime(),
                    Check_out = new DateTime(),
                };
                quartoLuxo.setDisponivel(false);
                reservas.Add(reserva);
                Console.Clear();
                Console.WriteLine("Reserva criada com sucesso!");
                Console.ReadLine();

            }catch(Exception e){

            }
        }
        public void CancelarReservaQuarto(int verificador,Hotel hotel){
            reservas.Find(x => {
                if(x.Id == verificador){
                    reservas.Remove(x);
                    quartosLuxo.ForEach(n => {
                        if(x.NumQuarto == n._numero){
                            n._disponivel = true;
                        }
                    });
                }
                return true;
            });
            
            Reserva.SalvarDadosReserva(hotel);
            QuartoLuxo.SalvarDadosQuartos(hotel);
            Console.Clear();
            Console.WriteLine("Reserva excluída com sucesso!");
            Console.ReadLine();
        }
        public void CarregarDados(){
            if(File.Exists("clientes.json")){
                clientes = JsonConvert.DeserializeObject<List<Cliente>>(File.ReadAllText("clientes.json"));
            }
            if(File.Exists("quartosLuxo.json")){
                quartosLuxo = JsonConvert.DeserializeObject<List<QuartoLuxo>>(File.ReadAllText("quartosLuxo.json"));
            }
            if(File.Exists("reservas.json")){
                reservas = JsonConvert.DeserializeObject<List<Reserva>>(File.ReadAllText("reservas.json"));
            }
        }
    }

}