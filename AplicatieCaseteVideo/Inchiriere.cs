using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieCaseteVideo {
    public class Inchiriere {
        private string numeFilm;
        private int cantitateImprumutata;

        public Inchiriere(string numeFilm, int cantitateImprumutata) {
            this.numeFilm = numeFilm;
            this.cantitateImprumutata = cantitateImprumutata;
            if (this.numeFilm.Length < 2)
                throw new Exception("Invalid name");
            if (this.cantitateImprumutata < 0)
                throw new Exception("Quantity can't be a negative");
        }

        public string NumeFilm {
            get {
                return this.numeFilm;
            }
            set {
                if (value.Length < 2)
                    MessageBox.Show("Too few characters");
                else
                    this.numeFilm = value;
            }
        }

        public int CantitateImprumutata {
            get {
                return this.cantitateImprumutata;
            }
            set {
                if (value < 0)
                    MessageBox.Show("Invalid quantity");
                else
                    this.cantitateImprumutata = value;
            }
        }
    }
}
