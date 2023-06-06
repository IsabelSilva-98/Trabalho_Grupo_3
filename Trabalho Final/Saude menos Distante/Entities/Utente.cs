using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saude_menos_Distante.Entities
{
    internal class Utente : Pessoas  //A classe Utente faz ligação à classe mãe (Pessoas)
    {
        // Propriedades
        public int NoUtente { get; set; }

        public Utente() { }


        // Construtores
        public Utente(int idPessoa) 
            :base (idPessoa)
        { 
        }

        //A classe Utente tem um NoUtente que a identifica. Recebe todas as propriedades da classe Pessoas
        public Utente(int idPessoa, string nome, string dataNascimento, string sexo, string email, int contacto, int noUtente)
        : base(idPessoa, nome, dataNascimento, sexo, email, contacto)
        {
            NoUtente = noUtente;
        }



        // Secção de métodos
        public override string ToString()
        {
            return "Id: " + IdPessoa
                + "\n"
                + "Nome: " + Nome
                + "\n"
                + "Data de nascimento: " + DataNascimento    //Para imprimir na consola
                + "\n"
                + "Sexo: " + Sexo
                + "\n"
                + "Email: " + Email
                + "\n"
                + "Contacto: " + Contacto
                + "\n"
                + "Número de Utente: " + NoUtente;
        }

        public static void RegistoUtente(Pessoas utente)
        {
            // Aqui o adminnistrativo insere as informações do utente de forma a registá-lo 
            Console.WriteLine();
            Console.WriteLine("Registe os dados do utente: ");
            Console.WriteLine("Id: ");
            Console.WriteLine(utente.IdPessoa);
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Data de nascimento: ");
            string dataNascimento = Console.ReadLine();
            Console.WriteLine("Sexo: ");
            string sexo = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Contacto: ");
            int contacto = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de Utente: ");
            int noUtente = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do Utente: ");
            Utente utente2 = new Utente(utente.IdPessoa, nome, dataNascimento, sexo, email, contacto, noUtente);
            Console.WriteLine(utente2);  //Imprime o override

        }
    }
}
