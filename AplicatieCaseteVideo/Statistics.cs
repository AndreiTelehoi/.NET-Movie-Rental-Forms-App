using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieCaseteVideo {
    public partial class Statistics : Form {

        Font font = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
        Color culoare = Color.Black;
        Pen pen1 = new Pen(Color.DarkTurquoise, 2);
        Brush br = new SolidBrush(Color.DarkCyan);
        Brush br2 = new SolidBrush(Color.Black);
        int[] v = new int[30]; int nr = 0;
        const int margine = 20;
        string[] denumiri = new string[30];

        public Statistics() {
            InitializeComponent();
        }

       

        private void panel1_Paint(object sender, PaintEventArgs e) {

            try {
                if (nr > 0) {
                    Graphics g = e.Graphics;
                    Rectangle rect = new Rectangle(panel1.Location.X + margine,
                     panel1.Location.Y + 4 * margine,
                        panel1.Width - 2 * margine,
                             panel1.Height - 8 * margine);
                    g.DrawRectangle(pen1, rect);
                    double l = rect.Width / nr / 3;
                    double d = (rect.Width - nr * l) / (nr + 1);
                    double vMax = v.Max();
                    Rectangle[] recs = new Rectangle[nr];

                    Point[] p = new Point[nr];


                    for (int i = 0; i < nr; i++) {


                        recs[i] = new Rectangle((int)(rect.Left + (i + 1) * d + i * l),
                        (int)(rect.Bottom - v[i] / vMax * rect.Height + 10),
                        (int)l, (int)(v[i] / vMax * rect.Height - 10));
                        Point pp = new Point((int)(recs[i].Location.X + 5), (int)(recs[i].Location.Y - font.Height));
                        p[i] = pp;
                        if (v[i] > 0) {
                            g.DrawString(v[i].ToString(), font, br2,
                                new Point((int)(recs[i].Location.X + 2), (int)(recs[i].Location.Y - font.Height - 16)));
                            string[] vec = denumiri[i].Split(' ');
                            for (int j = 0; j < vec.Length; j++) {
                                g.DrawString(vec[j].ToString(), font, br2,
                                  new Point((int)(recs[i].Location.X), (int)(recs[i].Location.Y + (v[i] / vMax * rect.Height) + j * 11)));

                            }
                        }

                    }
                    g.FillRectangles(br, recs);


                    for (int i = 0; i < nr - 1; i++) {
                        try {

                            Pen pen3 = new Pen(Color.Black, 2);
                            if (v[i] > 0) {

                                g.DrawCurve(pen3, p);

                            }
                        }
                        catch (Exception ex) {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                ///comanda.Transaction.Rollback();
            }
        }


    

    void pd_print(object sender, PrintPageEventArgs e) {

            try {
                if (nr > 0) {
                    Graphics g = e.Graphics;                   
                    Rectangle rect = new Rectangle(panel1.Location.X + margine,
                     panel1.Location.Y + 4 * margine,
                        panel1.Width - 2 * margine,
                             panel1.Height - 8 * margine);
                    g.DrawRectangle(pen1, rect);
                    double l = rect.Width / nr / 3;
                    double d = (rect.Width - nr * l) / (nr + 1);
                    double vMax = v.Max();
                    Rectangle[] recs = new Rectangle[nr];

                    Point[] p = new Point[nr];


                    for (int i = 0; i < nr; i++) {


                        recs[i] = new Rectangle((int)(rect.Left + (i + 1) * d + i * l),
                        (int)(rect.Bottom - v[i] / vMax * rect.Height + 10),
                        (int)l, (int)(v[i] / vMax * rect.Height - 10));
                        Point pp = new Point((int)(recs[i].Location.X + 5), (int)(recs[i].Location.Y - font.Height));
                        p[i] = pp;
                        if (v[i] > 0) {
                            g.DrawString(v[i].ToString(), font, br2,
                                new Point((int)(recs[i].Location.X + 2), (int)(recs[i].Location.Y - font.Height - 16)));
                            string[] vec = denumiri[i].Split(' ');
                            for (int j = 0; j < vec.Length; j++) {
                                g.DrawString(vec[j].ToString(), font, br2,
                                  new Point((int)(recs[i].Location.X), (int)(recs[i].Location.Y + (v[i] / vMax * rect.Height) + j * 11)));

                            }
                        }

                    }
                    g.FillRectangles(br, recs);


                    for (int i = 0; i < nr - 1; i++) {
                        try {

                            Pen pen3 = new Pen(Color.Black, 2);
                            if (v[i] > 0) {

                                g.DrawCurve(pen3, p);

                            }
                        }
                        catch (Exception ex) {
                            MessageBox.Show(ex.Message);
                        }

                    }
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
    
            }

        }

        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e) {
            StreamReader sr = new StreamReader("date_financiare.txt");
            string sLine = "";
            try {
                while (sLine != null) {
                    sLine = sr.ReadLine();
                    if (sLine != null) {
                        string[] linie = sLine.Split(';');
                        denumiri[nr] = linie[0].ToString();
                        v[nr] = Convert.ToInt32(linie[1].ToString());
                        nr++;

                    }
                }
                sr.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                
            }
            finally {
                sr.Close();
            }
            MessageBox.Show("Data was loaded");
            panel1.Invalidate();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e) {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_print);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e) {
            ((Form)this.TopLevelControl).Close();
            Form1 main = new Form1();
            main.Show();
        }
    }
}
