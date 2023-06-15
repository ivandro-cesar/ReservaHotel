using System;

namespace Hotel{
    public class QuartoLuxo : Quarto{
        public bool Suite{get;set;}

        public QuartoLuxo(){
            //this._maxPessoas = 3;
        }

        public static void ConsultaQuartosLuxo(Hotel hotel){
            for(int i=0;i < hotel.quartosLuxo.Count; i++){
                Console.Clear();
                Console.WriteLine("ID          Nome");    
                hotel.quartosLuxo.ForEach(obj => {
                    Console.Write($"{obj.getNum()}          ");
                });
                Console.ReadLine();
            }
        }
    }
}