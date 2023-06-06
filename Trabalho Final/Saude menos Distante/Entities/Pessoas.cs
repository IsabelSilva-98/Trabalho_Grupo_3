using Saude_menos_Distante.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saude_menos_Distante.Entities
{
    internal class Pessoas
    {
        //Propriedades
        public int IdPessoa { get; private set; }
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public int Contacto { get; set; }



        //Construtores
        public Pessoas()
        {
        }

        public Pessoas (int idPessoa)
        {
            IdPessoa = idPessoa;
        }

        public Pessoas(int idPessoa, string nome, string dataNascimento, string sexo, string email, int contacto) 
        {
            IdPessoa = idPessoa;
            Nome = nome;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            Email = email;
            Contacto = contacto; 
        }
    }
}
