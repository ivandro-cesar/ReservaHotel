using System;

namespace Hotel{

    public class Cliente : Pessoa{
        
        public override void ExibirClientes(){
            base.ExibirClientes();
        }
        public static void ConsultaClientes(Hotel hotel){
            for(int i=0;i < hotel.clientes.Count; i++){
                Console.Clear();
                Console.WriteLine("ID          Nome");    
                hotel.clientes.ForEach(obj => {
                    Console.Write($"{obj._id}          ");
                    Console.WriteLine($"{obj._nome}");
                });
                Console.ReadLine();
            }
        }
    }
}