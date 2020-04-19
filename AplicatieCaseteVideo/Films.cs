using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieCaseteVideo {
    public partial class Films : Form {

        const string ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\andreitelehoi\source\repos\AplicatieCaseteVideo\AplicatieCaseteVideo\DatabaseVHS.mdb";
        OleDbConnection connection = new OleDbConnection(ConnectionString);
        OleDbDataAdapter adapter;

        public Films() {
            InitializeComponent();
            extragereDate();
        }

        private void extragereDate() {
            if (connection.State == ConnectionState.Closed) {
                connection.Open();
            }
            DataTable dt = new DataTable();
            OleDbCommand SelectValues = connection.CreateCommand();
            SelectValues.CommandType = CommandType.Text;
            SelectValues.CommandText = "SELECT * FROM filme;";
            SelectValues.ExecuteNonQuery();
            adapter = new OleDbDataAdapter(SelectValues);
            adapter.Fill(dt);

            foreach (DataRow dr in dt.Rows) {
                populeaza(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
            }
            connection.Close();
        }

        private void populeaza(string id, string nume, string an, string regizor) {
            ListViewItem rand = new ListViewItem();
            rand.Text = id;
            rand.SubItems.Add(nume);
            rand.SubItems.Add(an);
            rand.SubItems.Add(regizor);
            listView1.Items.Add(rand);
        }

        private void Films_Load(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            listView1.Items.Clear();
            extragereDate();
        }

        private void addFilmToolStripMenuItem_Click(object sender, EventArgs e) {
            AddFilm adaugaFilm = new AddFilm();
            adaugaFilm.Show();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Save File";
            sfd.Filter = "Text File (.txt) | *.txt";
            string splitter = " ";
            if (sfd.ShowDialog() == DialogResult.OK) {
                filename = sfd.FileName.ToString();
                if (filename != "") {
                    using (StreamWriter sw = new StreamWriter(filename)) {
                        foreach (ListViewItem item in listView1.Items) {
                            sw.WriteLine("{0}{1}{2}{3}{4}{5}{6}", item.SubItems[0].Text,
                                splitter, item.SubItems[1].Text, splitter, item.SubItems[2].Text, splitter, item.SubItems[3].Text, splitter);
                                
                        }
                    }
                }

            }
        }

        private void removeFilmToolStripMenuItem_Click(object sender, EventArgs e) {
            try {

                ListViewItem randSelectat = listView1.SelectedItems[0];

                if (randSelectat != null) {
                    connection.Open();
                    string idSelectat = randSelectat.SubItems[0].Text;
                    OleDbCommand RemoveValues = connection.CreateCommand();
                    RemoveValues.CommandType = CommandType.Text;
                    RemoveValues.CommandText = "DELETE FROM Filme WHERE id = " + idSelectat + ";";
                    RemoveValues.ExecuteNonQuery();
                    listView1.Items.Clear();
                    extragereDate();
                    connection.Close();
                }
            }
            catch {
                MessageBox.Show("Please select a Film");
            }
        }
    }
}
