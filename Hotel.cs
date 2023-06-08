using System;

namespace Hotel{

    public class Hotel{
        public List<Cliente> clientes = new List<Cliente>();
        public List<QuartoPadrao> quartosPadrao = new List<QuartoPadrao>();
        public List<QuartoLuxo> quartosLuxo = new List<QuartoLuxo>();
        public List<QuartoMaster> quartosMaster = new List<QuartoMaster>();
        public List<Reserva> reservas = new List<Reserva>();

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
    }

}