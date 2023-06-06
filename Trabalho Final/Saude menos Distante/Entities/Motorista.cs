using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saude_menos_Distante.Entities
{
    internal class Motorista : Funcionario //A classe Motorista faz ligação à classe mãe (Funcionários, que por si está ligado à classe Pessoas)
    {
        //Propriedades
        public int Horas { get; set; }
        public double ValorPorHora { get; set; }

        //Construtores
        public Motorista() { }

        //A classe Motorista tem as propriedade Horas e ValorPorHora que a identifica. Recebe todas as propriedades da classe Funcionário e Pessoas
        public Motorista (int idPessoa, string nome, string dataNascimento, string sexo, string email, int contacto, int idFuncionario, int horas, double valorPorHora)
        : base(idPessoa, nome, dataNascimento, sexo, email, contacto, idFuncionario)
        {
            Horas = horas;
            ValorPorHora = valorPorHora;
        }

        //Secção de métodos
        public virtual double Salario()
        {
            return ValorPorHora * Horas;  //Para calcular o salário do motorista
        }
    }
}
