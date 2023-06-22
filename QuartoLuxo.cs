using System;

namespace Hotel{
    public class QuartoLuxo : Quarto{
        public bool Suite{get;private set;}

        public QuartoLuxo(int numero,bool disponivel,double valorDiaria,int maxPessoas,bool suite){
            Numero = numero;
            Disponivel = disponivel;
            ValorDiaria = valorDiaria;
            MaxPessoas = maxPessoas;
            Suite = suite;
        }

        public static void ConsultaQuartosLuxo(Hotel hotel){
            for(int i=0;i < hotel.quartosLuxo.Count; i++){
                Console.Clear();
                Console.WriteLine("ID          Nome");    
                hotel.quartosLuxo.ForEach(obj => {
                    Console.Write($"{obj.Numero}          ");
                });
                Console.ReadLine();
            }
        }
    }
}