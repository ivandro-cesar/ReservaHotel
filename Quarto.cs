using Newtonsoft.Json;

namespace Hotel{

    public abstract class Quarto{
        public int Numero{get;protected set;}
        public bool Disponivel{get;protected set;}
        public double ValorDiaria{get;protected set;}
        public int MaxPessoas{get;protected set;}

        public void setDisponivel(bool disp){
            Disponivel = disp;
        }

        public static void SalvarDadosQuartos(Hotel hotel){
            File.WriteAllText("quartosLuxo.json", JsonConvert.SerializeObject(hotel.quartosLuxo));
            File.WriteAllText("quartosPadrao.json", JsonConvert.SerializeObject(hotel.quartosPadrao));
            File.WriteAllText("quartosMaster.json", JsonConvert.SerializeObject(hotel.quartosMaster));
        }
    }

}