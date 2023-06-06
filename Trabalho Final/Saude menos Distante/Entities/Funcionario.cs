using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saude_menos_Distante.Entities
{
    internal class Funcionario : Pessoas  //A classe funcionario faz ligação à classe mãe (Pessoas)
    {
        //Propriedades
        public int IdFuncionario { get; set; }


        //Construtores
        public Funcionario()
        {
        }

        //A classe funcionario tem um IDFuncionario que a identifica. Recebe todas as propriedades da classe Pessoas
        public Funcionario(int idPessoa, string nome, string dataNascimento, string sexo, string email, int contacto, int idFuncionario)
        : base(idPessoa, nome, dataNascimento, sexo, email, contacto)
        {
            IdFuncionario = idFuncionario; 
        }
    }
}
