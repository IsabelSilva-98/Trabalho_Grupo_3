using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saude_menos_Distante.Entities
{
    internal class Calendario
    {
        //Propriedades
        public int Dia { get; set; }
        public string Mes { get; set; }
        public int Ano { get; set; }
        public string Hora { get; set; }



        //Construtores
        public Calendario()
        {

        }

        public Calendario(int ano)
        {
            Ano = ano;
        }

        public Calendario(string mes)
        {
            Mes = mes;
        }

        public Calendario(int dia, int ano, string hora)
        {
            Dia = dia;
            Ano = ano;
            Hora = hora;
        }



        //Secção de métodos
        public static void PrintCalendar(int month, int year)
        {
            //Aqui instanciamos um calendário na língua portuguesa e também instanciamos uma data de inicio e uma data final de forma a que na consola surja uma calendário com o mês e os dias corretos, assim como as horas das consultas
            CultureInfo culture = new CultureInfo("pt-BR");
            DateTime startDate = new DateTime(year, month, 1);
            DateTime endDate = startDate.AddMonths(1).AddDays(-1);

            Console.WriteLine();
            Console.WriteLine($"Calendário para {startDate.ToString("MMMM yyyy", culture)}:");
            Console.WriteLine("---------------------------");


            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1)) //Imprime o calendário
            {
                Console.WriteLine($"{date.ToString("MMMM, dd, dddd", culture)}");
                Console.WriteLine("Horas: 09:00;");
                Console.WriteLine("       10:00;");
                Console.WriteLine("       10:30;");
                Console.WriteLine("       11:30;");
                Console.WriteLine("       12:00;");
                Console.WriteLine("       14:00;");
                Console.WriteLine("       15:00;");
                Console.WriteLine("       16:30;");
                Console.WriteLine("       17:30;");
                Console.WriteLine();

            }
        }
    }
}
