using System;

namespace Hotel{

    public abstract class Pessoa: IPessoa{
        private string _cpf;
        private string _nome;

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