using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saude_menos_Distante.Entities
{
    internal class Despesa
    {
        //Propriedades
        public double Combustivel { get; set; }
        public int MapaKm { get; set; }
        public double Portagens { get; set; }



        //Construtores
        public Despesa() { }

        public Despesa(double combustivel, int mapaKm, double portagens)
        {
            Combustivel = combustivel;
            MapaKm = mapaKm;
            Portagens = portagens;
        }



        //Secção de métodos

        // Formulario para contabilização das despesas de deslocação, preenchidas pelo motorista. No fim imprime relatorio de despesas
        public static void RegistoDespesas()
        {
            Console.WriteLine();
            Console.WriteLine("Despesas: ");
            Console.WriteLine("- Combustível: ");
            double combustivel = double.Parse(Console.ReadLine());
            Console.WriteLine("- Mapa de km: ");
            int km = int.Parse(Console.ReadLine());
            Console.WriteLine("- Portagens: ");
            double portagens = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Despesa despesa = new Despesa(combustivel, km, portagens);
            Console.WriteLine(despesa); // Imprime o override
        }



        public override string ToString()
        {
            return "Despesas registadas "
                + "\n"
                + "- Combustivel: " + Combustivel
                + "\n"
                + "- Mapa de Km: " + MapaKm
                + "\n"
                + "- Portagens: " + Portagens;
        }
    }
}
