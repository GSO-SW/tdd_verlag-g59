using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verlag
{
    public class Buch
    {

        private string autor;

        public string Autor
        {
            get { return autor; }
            set
            {
                ArgumentNullException.ThrowIfNull(value);

                if (value.Contains("") || value.Contains("#") || value.Contains(";") 
                    || value.Contains("§") || value.Contains("%"))
                {
                    throw new ArgumentException("Unerlaubtes Zeichen für den Autor verwendet");
                }
                

                autor = value;

            }
        }

        private string titel;

        public string Titel
        {
            get { return titel; }
            set { titel = value; }
        }

        private int auflage;

        public int Auflage
        {
            get { return auflage; }
            set 
            {
                if (value > 0)
                {
                    auflage = value;
                }
                    
                else
                {
                    throw new ArgumentOutOfRangeException("Der Wert für die Auflage ist zu klein");
                }
            }
        }

        public Buch(string autor, string titel, int auflage = 1)
        {
            Autor = autor;
            Titel = titel;
            Auflage = auflage;
        }


    }
}
