using System;

namespace Hotel{

    public class QuartoPadrao : Quarto{
        public QuartoPadrao(int numero,bool disponivel,double valorDiaria,int maxPessoas){
            Numero = numero;
            Disponivel = disponivel;
            ValorDiaria = valorDiaria;
            MaxPessoas = maxPessoas;
        }
    }

}