using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saude_menos_Distante.Entities
{
    internal class Relatorio 
    {
       //Propriedades
        public DateTime DataRelatorio { get; set; }


       // Construtor
       public Relatorio (DateTime dataRelatorio)
        {
            DataRelatorio = dataRelatorio;
        }
        
    }
}
