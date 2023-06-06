using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saude_menos_Distante.Entities
{
    internal class RelatorioColaboradores : Relatorio  //A classe RelatorioColaboradores faz ligação à classe mãe (Relatorio)
    {
        //Propriedades
        public int Equipa { get; set; }
        public Enfermeira Enfermeira { get; set; }
        public Medico Medico { get; set; }
        public Administrativo Administrativo { get; set; }
        public Motorista Motorista { get; set; }

        //Construtores

        //A classe RelatorioColaboradores tem as propriedades Equipa,Enfermeira(que vem da classe Enfermeira), Medico(que vem da classe Medico), Administrativo(que vem da classe Administrativo) e a Motorista(que vem da classe Motorista) que a identifica. Recebe todas as propriedades da classe Relatorio
        public RelatorioColaboradores(DateTime dataRelatorio, int equipa, Enfermeira enfermeira, Medico medico, Administrativo administrativo, Motorista motorista)
        : base (dataRelatorio)
        {
            Equipa = equipa;
            Enfermeira = enfermeira;
            Medico = medico;
            Administrativo = administrativo;
            Motorista = motorista;
        }


        //Secção de métodos
        public static void RelatColab(Medico medico, Enfermeira enfermeira, Administrativo administrativo, Motorista motorista)
        {
            // Aqui mostra uma maneira de ir buscar o relatório de colaboradores, ou seja, ao inserir o número da equipa em questão (que neste caso é uma só equipa exemplo)
            Console.WriteLine();
            Console.WriteLine("Relatório de Colaboradores ");
            Console.WriteLine("Data: ");
            DateTime data = DateTime.Now;
            Console.WriteLine(DateTime.Now);

            Console.WriteLine();
            Console.WriteLine("Insira o número da equipa: ");
            int equipa = int.Parse(Console.ReadLine());
            Console.WriteLine();

            RelatorioColaboradores relatorio1 = new RelatorioColaboradores(data, equipa, enfermeira, medico, administrativo, motorista);

            Console.WriteLine();
            Console.WriteLine(relatorio1); // Impime o override
        }


        public override string ToString()
        {
            return "Equipa: " + Equipa
                + "\n"
                + "\r\n"

                + "Médico: " + Medico.Nome
                + "\n"
                + "- Data de Nascimento: " + Medico.DataNascimento
                + "\n"
                + "- Sexo: " + Medico.Sexo
                + "\n"
                + "- Email: " + Medico.Email
                + "\n"
                + "- Contacto: " + Medico.Contacto
                + "\n"
                + "- Id: " + Medico.IdFuncionario
                + "\n"
                + "- Horas trabalhadas: " + Medico.Horas
                + "\n"
                + "- Valor por hora: " + Medico.ValorPorHora
                + "\n"
                + "- Salário mensal: " + Medico.Salario()
                + "\n"

                +"\r\n"

                + "Enfermeira: " + Enfermeira.Nome
                + "\n"
                + "- Data de Nascimento: " + Enfermeira.DataNascimento
                + "\n"
                + "- Sexo: " + Enfermeira.Sexo
                + "\n"
                + "- Email: " + Enfermeira.Email
                + "\n"
                + "- Contacto: " + Enfermeira.Contacto
                + "\n"
                + "- Id: " + Enfermeira.IdFuncionario
                + "\n"
                + "- Horas trabalhadas: " + Enfermeira.Horas
                + "\n"
                + "- Valor por hora: " + Enfermeira.ValorPorHora
                + "\n"
                + "- Salário mensal: " + Enfermeira.Salario()
                + "\n"

                + "\r\n"

                + "Administrativo: " + Administrativo.Nome
                + "\n"
                + "- Data de Nascimento: " + Administrativo.DataNascimento
                + "\n"
                + "- Sexo: " + Administrativo.Sexo
                + "\n"
                + "- Email: " + Administrativo.Email
                + "\n"
                + "- Contacto: " + Administrativo.Contacto
                + "\n"
                + "- Id: " + Administrativo.IdFuncionario
                + "\n"
                + "- Horas trabalhadas: " + Administrativo.Horas
                + "\n"
                + "- Valor por hora: " + Enfermeira.ValorPorHora
                + "\n"
                + "- Salário mensal: " + Administrativo.Salario()
                + "\n"

                + "\r\n"

                + "Motorista: " + Motorista.Nome
                + "\n"
                + "- Data de Nascimento: " + Motorista.DataNascimento
                + "\n"
                + "- Sexo: " + Motorista.Sexo
                + "\n"
                + "- Email: " + Motorista.Email
                + "\n"
                + "- Contacto: " + Motorista.Contacto
                + "\n"
                + "- Id: " + Motorista.IdFuncionario
                + "\n"
                + "- Horas trabalhadas: " + Motorista.Horas
                + "\n"
                + "- Valor por hora: " + Motorista.ValorPorHora
                + "\n"
                + "- Salário mensal: " + Motorista.Salario()
                + "\n";
        }
    }
}
