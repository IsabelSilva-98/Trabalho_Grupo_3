using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saude_menos_Distante.Entities
{
    internal class RelatorioEstatisticas : Relatorio //A classe RelatorioEstatisticas faz ligação à classe mãe (Relatorio)
    {
        // Propriedades
        public int NoTotalConsultas { get; set; }
        public int ConsultasUltimaSemana { get; set; }
        public int  ConsultasUltimoDia { get; set; }


        // Construtores

        //A classe RelatorioEstatisticas tem as propriedades NoTotalConsultas, ConsultasUltimaSemana, ConsultasUltimoDia que a identifica. Recebe todas as propriedades da classe Relatorio
        public RelatorioEstatisticas(DateTime dataRelatorio)
            :base(dataRelatorio)
        {

        }
        public RelatorioEstatisticas(DateTime dataRelatorio, int noTotalConsultas, int consultasUltimaSemana, int consultasUltimoDia)
            :base(dataRelatorio)
        {
            NoTotalConsultas = noTotalConsultas;
            ConsultasUltimaSemana = consultasUltimaSemana;
            ConsultasUltimoDia = consultasUltimoDia;
        }



        //Secção de métodos
        public static void RelatEstatisticas()
        {
            //Foi criada uma lista de consultas de forma a fazer a contagem das mesma para o relatório de estatisticas
            List<Consulta> consultas = new List<Consulta>();

            //Foram instaciadas diversas para haver ainda uma diferença entre as totais e as consultas da última semana e do último dia
            Consulta consulta9 = new Consulta(2501, "2023/06/09", "HTA Grau II", "Hipertiroidismo", "Eutirox 50", "Eutirox 75");
            Consulta consulta10 = new Consulta(2500, "2023/06/08", "HTA Grau I", "Covid-19", "Pfizer", "Johnson");
            Consulta consulta11 = new Consulta(2499, "2023/06/07", "Hipertensão Sistólica Isolada", "Anemia", "Ferro", "Análises ao Sangue");
            Consulta consulta12 = new Consulta(2498, "2023/06/07", "HTA Grau II", "Diabetes", "Insulina", "Análises ao Sangue");
            Consulta consulta13 = new Consulta(2497, "2023/06/07", "HTA Grau III", "Esteoperose", "Brufen", "TAC");
            Consulta consulta14 = new Consulta(2496, "2023/06/08", "HTA Grau III", "Diabetes", "Insulina", "Raio X");
            Consulta consulta15 = new Consulta(2495, "2023/06/09", "HTA Grau I", "Diabetes", "Insulina", "DiabetMed") ;
            Consulta consulta16 = new Consulta(2494, "2023/06/09", "Noraml Alto", "Sem antecendente", "Não tem medicação prévia", "Análises de Sangue");
            Consulta consulta17 = new Consulta(2493, "2023/06/09", "Hipertensão Sistólica Isolada", "Rinite Alérgica", "Antapolor", "MRI");
            Consulta consulta18 = new Consulta(2492, "2023/06/09", "HTA Grau II", "Artrite Reumatóide", "Strepsil", "Raio X");
            Consulta consulta19 = new Consulta(2491, "2023/06/06", "HTA Grau I", "Diabetes", "Insulina", "MRI");
            Consulta consulta20 = new Consulta(2490, "2023/06/06", "Normal", "Tendinite", "Benuron", "Alprazolam");
            Consulta consulta21 = new Consulta(2489, "2023/06/02", "Normal", "Diabetes", "Insulina", "MRI");
            Consulta consulta22 = new Consulta(2488, "2023/06/06", "HTA Grau III", "Cirrose", "PharmaX", "PharmaY");
            Consulta consulta23 = new Consulta(2487, "2023/06/04", "Normal", "Pneumonia", "Pneumoronix", "Pulmobon");
            Consulta consulta24 = new Consulta(2486, "2023/06/04", "Ótima", "Papeira", "Paponix 32", "Broncolax");
            Consulta consulta25 = new Consulta(2485, "2023/06/04", "HTA Grau I", "Tuberculose", "TuberSixlac", "Asmolix");
            Consulta consulta26 = new Consulta(2484, "2023/06/03", "HTA Grau I", "HepatiteABC", "HepaCurex", "TitesXH");
            Consulta consulta27 = new Consulta(2483, "2023/06/03", "Normal", "Sífilis", "HepaCurex", "TitesXH");
            Consulta consulta28 = new Consulta(2482, "2023/06/02", "Normal", "Trombose", "Trombocan", "TrifonLx");
            Consulta consulta29 = new Consulta(2481, "2023/06/02", "HTA Grau I", "Hipertiroidismo", "Eutirox 100", "Eutirox 75");
            Consulta consulta30 = new Consulta(2480, "2023/06/01", "HTA Grau I", "Tendinite", "Benuron", "Sertalina" );   



            consultas.Add(consulta9);
            consultas.Add(consulta10);
            consultas.Add(consulta11);
            consultas.Add(consulta12);
            consultas.Add(consulta13);
            consultas.Add(consulta14);
            consultas.Add(consulta15);
            consultas.Add(consulta16);
            consultas.Add(consulta17);
            consultas.Add(consulta18);
            consultas.Add(consulta19);
            consultas.Add(consulta20);
            consultas.Add(consulta21);
            consultas.Add(consulta22);
            consultas.Add(consulta23);
            consultas.Add(consulta24);
            consultas.Add(consulta25);
            consultas.Add(consulta26);
            consultas.Add(consulta27);
            consultas.Add(consulta28);
            consultas.Add(consulta29);
            consultas.Add(consulta30);

            Console.WriteLine("Relatório de Estatísticas");
            Console.WriteLine();

            Console.WriteLine("Até que data: ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();


            //Foi utilizado um count com parametros espeficicados de forma a fazer a contagem corretamente
            int noConsulta = consultas.Count;

            int noConsultaSemana = consultas.Count(c => c.Data == "2023/06/09" || c.Data == "2023/06/08" || c.Data == "2023/06/07" || c.Data == "2023/06/06" || c.Data == "2023/06/05");


            int noConsultaDia = consultas.Count(c => c.Data == "2023/06/09");


            RelatorioEstatisticas relatorioEstatisticas = new RelatorioEstatisticas(data, noConsulta, noConsultaSemana, noConsultaDia);

            Console.WriteLine(relatorioEstatisticas);  // Imprime o override
        }



        public override string ToString()
        {
            return "Número Total de consultas: " + NoTotalConsultas
                + "\n"
                + "Número de consultas na última semana: " + ConsultasUltimaSemana
                + "\n"
                + "Número de consultas no último dia: " + ConsultasUltimoDia;
        }





    }
}
