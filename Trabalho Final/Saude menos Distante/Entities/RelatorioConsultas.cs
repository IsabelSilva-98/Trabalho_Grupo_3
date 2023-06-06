using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saude_menos_Distante.Entities
{
    internal class RelatorioConsultas : Relatorio //A classe RelatorioConsultas faz ligação à classe mãe (Relatorio)
    {
        // Propriedades
        public Utente Utente { get; set; }
        public Triagem Triagem { get; set; }
        public Consulta Consulta { get; set; }

        // Construtores

        //A classe RelatorioConsultas tem as propriedades Utente(que vem da classe Utente), Triagem(que vem da classe Triagem), Consulta(que vem da classe Conculta) que a identifica. Recebe todas as propriedades da classe Relatorio
        public RelatorioConsultas(DateTime dataRelatorio)
        : base(dataRelatorio)
        { }

        public RelatorioConsultas(DateTime dataRelatorio, Utente utente, Triagem triagem, Consulta consulta)
            : base(dataRelatorio)
        {
            Utente = utente;
            Triagem = triagem;
            Consulta = consulta;
        }



        // Secção de métodos
        public static void RelatConsultas(Utente utente1, Triagem triagem, Utente utente2, Utente utente3, Utente utente4, Utente utente5, Utente utente6, Utente utente7, Triagem triagem2, Triagem triagem3, Triagem triagem4, Triagem triagem5, Triagem triagem6, Triagem triagem7)
        {

            // Serve para mostrar que ao escolher uma data (30/05/2023) especifica vai aparecer o relatório desse diaConsole.WriteLine();
            Console.WriteLine("Escolha uma data: ");
            DateTime dataEscolhida = DateTime.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Relatório de Consultas: ");


            if (dataEscolhida == DateTime.Parse("30/05/2023"))
            {
                //Vai surgir esta lista de utentes
                Console.WriteLine();
                Console.WriteLine("Nome: " + utente1.Nome);
                Console.WriteLine("Número de utente: " + utente1.NoUtente);
                Console.WriteLine("Diagnóstico: " + triagem.Diagnostico);
                Console.WriteLine();

                Console.WriteLine();
                Console.WriteLine("Nome: " + utente2.Nome);
                Console.WriteLine("Número de utente: " + utente2.NoUtente);
                Console.WriteLine("Diagnóstico: " + triagem2.Diagnostico);
                Console.WriteLine();

                Console.WriteLine("Nome: " + utente3.Nome);
                Console.WriteLine("Número de utente: " + utente3.NoUtente);
                Console.WriteLine("Diagnóstico: " + triagem3.Diagnostico);
                Console.WriteLine();

                Console.WriteLine("Nome: " + utente4.Nome);
                Console.WriteLine("Número de utente: " + utente4.NoUtente);
                Console.WriteLine("Diagnóstico: " + triagem4.Diagnostico);
                Console.WriteLine();

                Console.WriteLine("Nome: " + utente5.Nome);
                Console.WriteLine("Número de utente: " + utente5.NoUtente);
                Console.WriteLine("Diagnóstico: " + triagem5.Diagnostico);
                Console.WriteLine();

                Console.WriteLine("Nome: " + utente6.Nome);
                Console.WriteLine("Número de utente: " + utente6.NoUtente);
                Console.WriteLine("Diagnóstico: " + triagem6.Diagnostico);
                Console.WriteLine();

                Console.WriteLine("Nome: " + utente7.Nome);
                Console.WriteLine("Número de utente: " + utente7.NoUtente);
                Console.WriteLine("Diagnóstico: " + triagem7.Diagnostico);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Relatório ainda não gerado"); // Se não introduzir a data correta surge mensagem de aviso
            }
        }
    }
}
