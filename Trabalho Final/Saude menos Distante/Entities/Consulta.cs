using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saude_menos_Distante.Entities
{
    internal class Consulta
    {
        //Propriedades
        public int IdConsulta { get; set; }
        public string Data { get; set; }
        public string Diagnostico { get; set; }
        public string Antecedentes { get; set; }
        public string Medicacao { get; set; }
        public string Prescriçao { get; set; }
        public Utente Utente { get; set; }

        public Triagem Triagem { get; set; }

        

        //Construtores
        public Consulta() { }

        public Consulta(int idConsulta)
        {
            IdConsulta = idConsulta;
        }

        public Consulta(int idConsulta, string data, string diagnostico, string antecedentes, string medicacao, string prescricao)
        {
            IdConsulta = idConsulta;
            Data = data;
            Diagnostico = diagnostico;
            Antecedentes = antecedentes;
            Medicacao = medicacao;
            Prescriçao = prescricao;
        }
        public Consulta(string data, Triagem triagem, string antecedentes, string medicacao, string prescricao)
        {
            Data = data;
            Triagem = triagem;
            Antecedentes = antecedentes;
            Medicacao = medicacao;
            Prescriçao = prescricao;
        }




        //Secção de métodos

        //Aqui fazemos o registo da consulta (apenas o Doutor faz este registo)
        public static void RegistarConsulta(Pessoas pessoas, Utente utente1, Consulta consulta2, Triagem triagem, Consulta consulta)
        {
            Console.WriteLine();
            Console.WriteLine("Dados Utente: ");
            Console.WriteLine(utente1);
            Console.WriteLine();
            Console.WriteLine("Triagem: ");
            Console.WriteLine(triagem);

            Console.WriteLine();
            Console.WriteLine("Data da Consulta: ");
            string data = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Diagnóstico: " + triagem.Diagnostico);  //Imprime os dados relativos à triagem, para informação do Doutor

            Console.WriteLine();
            Console.WriteLine("Antecedentes de saúde: ");
            string antecedentes = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Medicação Habitual: ");
            string medicacao = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Receitas ou prescrições: ");
            string receitas = Console.ReadLine();
            Console.WriteLine();

            Consulta consulta1 = new Consulta(data, triagem, antecedentes, medicacao, receitas);
            Console.WriteLine(consulta1);  // Imprime todos os dados relativos à consulta, bem como historico do paciente
        }


        public override string ToString()
        {
            return "Resumo: "
                + "\n"
                + "Data: " + Data
                + "\n"
                + "Diagnóstico: " + Triagem.Diagnostico
                + "\n"
                + "Antecedentes: " + Antecedentes
                + "\n"
                + "Medicação Habitual: " + Medicacao
                + "\n"
                + "Prescrições: " + Prescriçao;
        }
    }
}
