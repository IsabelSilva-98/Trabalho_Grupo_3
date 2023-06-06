using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saude_menos_Distante.Entities
{
    internal class Triagem
    {
        // Propiedades
        public double Peso { get; set; }
        public double Altura { get; set; }
        public int NivelColestrol { get; set; }
        public int NivelGlicose { get; set; }
        public int PressaoArterialSistolica { get; set; }
        public int PressaoArterialDiastolica { get; set; }
        public string Diagnostico { get; set; }



        // Construtores
        public Utente Utente { get; set; }

        public Triagem()
        {
        }

        public Triagem(double peso, double altura, int nivelColestrol, int nivelGlicose, int pressaoArterialSistolica, int pressaoArterialDiastolica)
        {
            Peso = peso;
            Altura = altura;
            NivelColestrol = nivelColestrol;
            NivelGlicose = nivelGlicose;
            PressaoArterialSistolica = pressaoArterialSistolica;
            PressaoArterialDiastolica = pressaoArterialDiastolica;
        }

        public Triagem(double peso, double altura, int nivelColestrol, int nivelGlicose, int pressaoArterialSistolica, int pressaoArterialDiastolica, string diagnostico)
        {
            Peso = peso;
            Altura = altura;
            NivelColestrol = nivelColestrol;
            NivelGlicose = nivelGlicose;
            PressaoArterialSistolica = pressaoArterialSistolica;
            PressaoArterialDiastolica = pressaoArterialDiastolica;
            Diagnostico = diagnostico;
        }

        //Secção de métodos

        public static void RegistoTriagem(Utente utente1)
        {
            Console.WriteLine();
            Console.WriteLine("Registo do utente: ");   // Aqui vai surgir a informação do registo realizado pelo admin (um exemplo)
            Console.WriteLine();
            Console.WriteLine(utente1);
            Console.WriteLine();


            //Aqui é a secção onde a enfermeira insere a triagem do utente 
            Console.WriteLine("Insira triagem do utente: " + utente1.Nome);
            Console.WriteLine("Peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Colestrol: ");
            int colestrol = int.Parse(Console.ReadLine());
            Console.WriteLine("Glicose: ");
            int glicose = int.Parse(Console.ReadLine());
            Console.WriteLine("Tensão Sistolica: ");
            int tensaoArterialSistolica = int.Parse(Console.ReadLine());
            Console.WriteLine("Tensão Diastolica: ");
            int tensaoArterialDiastolica = int.Parse(Console.ReadLine());
            
            



            Console.WriteLine();
            Console.WriteLine("Triagem adicionada: ");

            Triagem triagem1 = new Triagem(peso, altura, colestrol, glicose, tensaoArterialSistolica, tensaoArterialDiastolica);
            Console.WriteLine(triagem1);  // Vai imprimir o override


            // O if serve para quando o utilizador introduzir a tensão sistólica e diastólica o programa consiga mostrar qual o diagnóstico do utente
            if (tensaoArterialSistolica < 120 && tensaoArterialDiastolica < 80)
            {
                Console.WriteLine("    - Ótima");
            }
            else if (tensaoArterialSistolica < 130 && tensaoArterialDiastolica < 85)
            {
                Console.WriteLine("    - Normal");
            }
            else if (tensaoArterialSistolica <140 && tensaoArterialDiastolica < 90)
            {
                Console.WriteLine("    - Normal-Alta");
            }
            else if (tensaoArterialSistolica < 160 && tensaoArterialDiastolica < 100)
            {
                Console.WriteLine("    - HTA Grau I");
            }
            else if (tensaoArterialSistolica < 180 && tensaoArterialDiastolica < 110)
            {
                Console.WriteLine("    - HTA Grau II");
            }
            else if (tensaoArterialSistolica >= 140 && tensaoArterialDiastolica < 90)
            {
                Console.WriteLine("    - Hipertensão Sistólica Isolada");
            }
            else
            {
                Console.WriteLine("    - HTA Grau III");
            }

            
        }

        public double IMC()
        {
            return Peso * Altura / 2;  //Um método para calcular o Indice de massa corporal
        }

        public override string ToString()
        {
            return "- Peso: " + Peso
                + "\n"
                + "- Altura: " + Altura
                + "\n"
                + "- Colestrol: " + NivelColestrol
                + "\n"
                + "- Glicose: " + NivelGlicose
                + "\n"
                + "- IMC: " + IMC()
                + "\n"
                + "- Pressão Arterial Sistólica: " + PressaoArterialSistolica
                + "\n"
                + "- Pressão Arterial Diastólica: " + PressaoArterialDiastolica
                + "\n"
                + "- Diagnóstico: " + Diagnostico;

                
               
        }
    }
}
