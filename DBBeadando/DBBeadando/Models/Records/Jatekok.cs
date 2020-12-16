using DBBeadando.Exceptions;
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
                    throw new NullException("Az asztalkód nem lehet nulla!");
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
                    throw new NullException("A gyártó nem lehet nulla!");
                }
                gyarto = value; 
            }
        }

        private string asztallimit;

        public string Asztallimit
        {
            get { return asztallimit; }
            set 
            {
                if (value == null)
                {
                    throw new NullException("A limit  nem lehet nulla");
                }
                if (value.Length > 100000)
                {
                    throw new OutOfRangeException("A Limit felső értéke 100000!")
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
                    throw new NullException("A Krupie neve nem lehet üres!");
                }
                krupie = value; 
            }
        }

        private DateTime asztal_datuma;

        public DateTime Asztal_datuma
        {
            get { return asztal_datuma; }
            set { asztal_datuma = value; }
        }

        private string jatektipusa;

        public string Jatektipusa
        {
            get { return jatektipusa; }
            set 
            {
                if (value == null)
                {
                    throw new NullException("A jaték típusa nem lehet üres!");
                }
                jatektipusa = value; 
            }
        }










    }
}
