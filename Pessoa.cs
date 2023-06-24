using System;

namespace Hotel{

    public abstract class Pessoa: IPessoa{
        public string Cpf{get;protected set;}
        public string Nome{get;protected set;}
        public int Id{get;protected set;}
        public string Telefone{get;protected set;}

        public Pessoa(int id,string cpf, string nome, string telefone){
            Id = id;
            Cpf = cpf;
            Nome = nome;
            Telefone = telefone;
        }

        public virtual void ExibirPessoas(){
            Console.WriteLine($"CPF: {Cpf}, nome: {Nome}");
        }
    }
}