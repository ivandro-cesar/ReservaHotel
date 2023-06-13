using System;
using Newtonsoft.Json;

namespace Hotel{

    public class Hotel{
        public List<Cliente> clientes = new List<Cliente>();
        public static List<QuartoPadrao> quartosPadrao = new List<QuartoPadrao>();
        public static List<QuartoLuxo> quartosLuxo = new List<QuartoLuxo>();
        public static List<QuartoMaster> quartosMaster = new List<QuartoMaster>();
        public static List<Reserva> reservas = new List<Reserva>();

        public void ReservarQuarto(string cpfCliente, int numQuarto){
            try{
                QuartoLuxo quarto = quartosLuxo.Find(q => q.getNum() == numQuarto && q.getDisponivel() == true);

                Cliente cliente = clientes.Find(c => c.getCpf() == cpfCliente);

                Reserva reserva = new Reserva{
                    Id = reservas.Count + 1,
                    ClienteReserva = cliente,
                    QuartoReserva = quarto,
                    QntPessoas = 2,
                    Check_in = new DateTime(),
                    Check_out = new DateTime(),
                };
                quarto.setDisponivel(false);
                reservas.Add(reserva);

            }catch(Exception e){

            }
        }
        public void CancelarReservaQuarto(int idCliente, int numQuarto){

        }
        public void SalvarDados(){
            File.WriteAllText("clientes.json",  JsonConvert.SerializeObject(clientes));
            //File.WriteAllText("quartosLuxo.json", JsonConvert.SerializeObject(quartosLuxo));
            //File.WriteAllText("reservas.json", JsonConvert.SerializeObject(reservas));
        }
        public void CarregarDados(){
            if(File.Exists("clientes.json")){
                clientes = JsonConvert.DeserializeObject<List<Cliente>>(File.ReadAllText("clientes.json"));
            }
            /*if(File.Exists("quartosLuxo.json")){
                quartosLuxo = JsonConvert.DeserializeObject<List<QuartoLuxo>>(File.ReadAllText("livros.json"));
            }
            if(File.Exists("reservas.json")){
                reservas = JsonConvert.DeserializeObject<List<Reserva>>(File.ReadAllText("emprestimos.json"));
            }*/
        }
    }

}