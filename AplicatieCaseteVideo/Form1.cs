using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieCaseteVideo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            Clients clienti = new Clients();
            this.Hide();
            clienti.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            Films filme = new Films();
            this.Hide();
            filme.Show();
        }

        private void button4_Click(object sender, EventArgs e) {
            
        }

        private void button3_Click(object sender, EventArgs e) {
            Statistics stat = new Statistics();
            this.Hide();
            stat.Show();
        }
    }
}
