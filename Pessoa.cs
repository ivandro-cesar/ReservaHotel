using System;

namespace Hotel{

    public abstract class Pessoa: IPessoa{
        public string _cpf;
        public string _nome;
        public int _id;
        public string _telefone{get;set;}

        public virtual void ExibirClientes(){
            Console.WriteLine($"CPF: {_cpf}, nome: {_nome}");
        }

        public string getCpf(){
            return _cpf;
        }
        public string getNome(){
            return _nome;
        }
        
        
    }
}