using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieCaseteVideo {
    class Client {
        private string numeClient;
        private string sex;
        private int varsta;
        private string telefon;

        public Client(string nume, string sex, int varsta, string telefon) {
            this.numeClient = nume;
            this.sex = sex;
            this.varsta = varsta;
            this.telefon = telefon;
            if (this.numeClient.Length < 2)
                throw new Exception("Invalid name");
            if (this.varsta < 0)
                throw new Exception("Age can't be a negative");
            if (this.telefon.Length != 10) 
                throw new Exception("Invalid phone number");
        }

        public string NumeClient {
            get {
                return this.numeClient;
            }
            set {
                if (value.Length < 2)
                    MessageBox.Show("Too few characters");
                else
                    this.numeClient = value;
            }
        }

        public int Varsta {
            get {
                return this.varsta;
            }
            set {
                if (value < 0)
                    MessageBox.Show("invalid age");
                else
                    this.varsta = value;
            }
        }

        public string Telefon {
            get {
                return this.telefon;
            }

            set {
                if (value.Length != 10)
                    MessageBox.Show("Invalid Phone Number");
                else
                    this.telefon = value;
            }
        }

        public string Sex {
            get {
                return this.sex;
            }

            set {
                if (value != "M" || value != "F")
                    MessageBox.Show("Invalid gender");
                else
                    this.sex = value;

            }
        }
    }
}
