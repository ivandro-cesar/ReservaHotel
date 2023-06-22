using System;

namespace Hotel{

    public abstract class Pessoa: IPessoa{
        public string Cpf{get;protected set;}
        public string Nome{get;protected set;}
        public int Id{get;protected set;}
        public string Telefone{get;protected set;}

        public virtual void ExibirPessoas(){
            Console.WriteLine($"CPF: {Cpf}, nome: {Nome}");
        }
    }
}