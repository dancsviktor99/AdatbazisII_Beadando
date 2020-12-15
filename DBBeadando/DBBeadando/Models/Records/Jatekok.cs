using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBBeadando.Models.Records
{
    public class Jatekok
    {
        private string asztalkod;

        public string Asztalkod
        {
            get { return asztalkod; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Az asztalkód nem lehet nulla!");
                }
                asztalkod = value; 
            }
        }
        private string jatekasztalneve;

        public string Jatekasztalneve
        {
            get { return jatekasztalneve; }
            set { jatekasztalneve = value; }
        }

        private string gyarto;

        public string Gyarto
        {
            get { return gyarto; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("A gyártó nem lehet nulla!");
                }
                gyarto = value; 
            }
        }

        private int asztallimit;

        public int Asztallimit
        {
            get { return asztallimit; }
            set 
            {
                if (value <=  0 || value > 100000)
                {
                    throw new ArgumentException("Nem lehet nulla és negatív, továbbá 100.000 felett!");
                }
                asztallimit = value; 
            }
        }

        private string krupie;

        public string Krupie
        {
            get { return krupie; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentException("A Krupie neve nem lehet üres!");
                }
                krupie = value; 
            }
        }

        private int asztal_datuma;

        public int Asztal_datuma
        {
            get { return asztal_datuma; }
            set { asztal_datuma = value; }
        }

        private string jatektipusa;
                    
        public string Jatektipusa
        {
            get { return jatektipusa; }
            set { jatektipusa = value; }
        }









    }
}
