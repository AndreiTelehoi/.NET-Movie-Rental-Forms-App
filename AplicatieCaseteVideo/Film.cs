using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieCaseteVideo {
    public class Film {
        private string nume;
        private int an;
        private string regizor;

        public Film(string nume, int an, string regizor) {
            this.nume = nume;
            this.an = an;
            this.regizor = regizor;

            if (this.nume.Length < 2)
                throw new Exception("Invalid name");

            if (this.an < 0 || this.an >2020)
                throw new Exception("Invalid year");

            if (this.regizor.Length < 2)
                throw new Exception("Invalid director");
        }

        public string Nume {
            get {
                return this.nume;
            }
            set {
                if (value.Length < 2)
                    MessageBox.Show("Invalid name");
                else
                    this.nume = value;
            }
        }
        public int An {
            get {
                return this.an;
            }

            set {
                if (value < 0 || value>2020)
                    MessageBox.Show("Invalid year");
                else
                    this.an = value;
            }

        }
        public string Regizor {
            get {
                return this.regizor;
            }
            set {
                if (value.Length < 2)
                    MessageBox.Show("Invalid director");
                else
                    this.regizor = value;
            }
        }
        public override string ToString() {
            return this.nume + " (" + this.an + "), regizat de " + this.regizor;
        }
    }
}
