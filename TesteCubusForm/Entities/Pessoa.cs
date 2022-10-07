using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCubusForm.Entities
{
    internal class Pessoa
    {
        //Properties
        public int Id { get; private set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string DataNascimento { get; set; }
        public string Cpf { get; set; }

        //Constructors
        public Pessoa()
        {

        }

        public Pessoa(string nome, string sobrenome, string dataNascimento, string cpf)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
        }

        public Pessoa(int id, string nome, string sobrenome, string dataNascimento, string cpf)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
            DataNascimento = dataNascimento;
            Cpf = cpf;
        }


        //ToString
        public override string ToString()
        {
            return "Id : " + Id
                   + "Nome : " + Nome
                   + "Sobrenome : " + Sobrenome
                   + "Data de nascimento : " + DataNascimento
                   + "Cpf : " + Cpf;
        }
    }
}
