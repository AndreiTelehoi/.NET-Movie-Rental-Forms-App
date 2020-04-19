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
using System.IO;

namespace AplicatieCaseteVideo {
    public partial class AddFilm : Form {

        const string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\andreitelehoi\source\repos\AplicatieCaseteVideo\AplicatieCaseteVideo\DatabaseVHS.mdb";
        OleDbConnection connection = new OleDbConnection(ConnectionString);
        

        public AddFilm() {
            InitializeComponent();
            panel1.AllowDrop = true;
            panel1.DragEnter += dragEnter;
            panel1.DragDrop += dragDrop;

        }

        private void dragEnter(object sender, DragEventArgs e) {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void dragDrop(object sender, DragEventArgs e) {
            string[] data = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (data != null) {
                foreach (string name in data) {
                    string valori = File.ReadAllText(name);
                    string[] data2 = valori.Split(',');
                    if (data2.Length == 3) {
                        textBox1.Text = data2[0];
                        textBox2.Text = data2[1];
                        textBox3.Text = data2[2];
                    }
                    else {
                        MessageBox.Show("Insert more data into txt file!");
                    }
                }
            }
        }
        private void AddFilm_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            connection.Open();
            OleDbCommand insertValues = connection.CreateCommand();
            insertValues.CommandType = CommandType.Text;

            try {
                Film filmNou = new Film(textBox1.Text, int.Parse(textBox2.Text), textBox3.Text);

                insertValues.CommandText = "INSERT INTO filme( Nume, An, Regizor) VALUES ('" + filmNou.Nume + "','" + filmNou.An + "','" + filmNou.Regizor + "');";
                insertValues.ExecuteNonQuery();
                MessageBox.Show("You added a new film to the VHS Collection!");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e) {
            Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) {
      
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void panel1_Paint(object sender, PaintEventArgs e) {

        }
    }
}
