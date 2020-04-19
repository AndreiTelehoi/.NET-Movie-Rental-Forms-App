using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;

namespace AplicatieCaseteVideo {
    public partial class AddClient : Form {

        const string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\andreitelehoi\source\repos\AplicatieCaseteVideo\AplicatieCaseteVideo\DatabaseVHS.mdb";
        OleDbConnection connection = new OleDbConnection(ConnectionString);

        public AddClient() {
            InitializeComponent();
        }

        private void AddClient_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            connection.Open();
            OleDbCommand insertValues = connection.CreateCommand();
            insertValues.CommandType = CommandType.Text;

            try {
                Client clientNou = new Client(textBox1.Text, comboBox1.Text, int.Parse(textBox2.Text), textBox3.Text);

                insertValues.CommandText = "INSERT INTO Clienti( Nume, Sex, Varsta, Telefon) VALUES ('" + clientNou.NumeClient + "','" + clientNou.Sex + "','" + clientNou.Varsta + "','" + clientNou.Telefon + "');";
                insertValues.ExecuteNonQuery();
                MessageBox.Show("Client added sucsesfully");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
