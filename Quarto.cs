using Newtonsoft.Json;

namespace Hotel{

    public abstract class Quarto{
        public int _numero;
        public bool _disponivel;
        public double _valorDiaria;
        public int _maxPessoas;

        public int getNum(){
            return _numero;
        }
        public bool getDisponivel(){
            return _disponivel;
        }
        public void setDisponivel(bool disp){
            _disponivel = disp;
        }

        public static void SalvarDadosQuartos(Hotel hotel){
            File.WriteAllText("quartosLuxo.json", JsonConvert.SerializeObject(hotel.quartosLuxo));
        }
    }

}