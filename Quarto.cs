namespace Hotel{

    public abstract class Quarto{
        private int _numero;
        private bool _disponivel;
        private double _valorDiaria;
        private int _maxPessoas;

        public int getNum(){
            return _numero;
        }
        public bool getDisponivel(){
            return _disponivel;
        }
        public void setDisponivel(bool disp){
            _disponivel = disp;
        }

    }

}