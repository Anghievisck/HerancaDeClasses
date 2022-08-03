using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heranca_de_classes
{
    public abstract class Pessoa
    {
        private string nome;
        private int idade;

        public Pessoa()
        {
            this.nome = null;
            this.idade = 0;
        }

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public string Nome
        { 
            get { return nome; }
            set { nome = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public abstract String ImprimeDados();
    }

    public class Professor : Pessoa
    {
        private string titulacao;

        public Professor()
        {
            this.titulacao = null;
        }

        public Professor(string nome, int idade, string titulacao)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Titulacao= titulacao;
        }

        public string Titulacao
        {
            get { return titulacao; }
            set { titulacao = value; }
        }
        
        public override String ImprimeDados()
        {
            String s = String.Empty;
            s = String.Concat(this.Nome, "", this.Idade.ToString(), "", this.Titulacao);
            return s;
        }
    }

    public class Aluno : Pessoa 
    {
        private string curso;

        public Aluno()
        {
            this.curso = null;
        }

        public Aluno(string nome, int idade, string curso)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Curso = curso;
        }

        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }

        public override string ImprimeDados()
        {
            String s = String.Empty;
            s = String.Concat(this.Nome, "", this.Idade.ToString(), "", this.Curso);
            return s;
        }
    }
}
