using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgettoPersona
{
    class Persona
    {
        private string _nome;
        public string nome { set; get; }

        private string _cognome;
        public string cognome { set; get; }

        private int _anni;
        public int anni
        { 
            set
            {
                if (value < 1) value = 1;
                value = _anni;
            }
            get { return _anni; } 
        }

        public string codice_fiscale { get { return _nome + _cognome + _anni; } }

        public Persona (string nome , string cognome , int anni)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.anni = anni;
        }

        public string describe ()
        {
            string output;
            return output = "nome :" + nome + "\r\n";
        }

    }
    
}
