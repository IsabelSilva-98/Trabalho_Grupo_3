using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saude_menos_Distante.Entities
{
    internal class Login
    {
        //Propriedades
        public string UserName { get; set; }
        public string Password { get; set; }


        //Construtores
        public Login() { }

        public Login(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
