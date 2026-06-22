using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.SQLite;

namespace ProiectPaw_CasaDeSchimbValutar
{
    public partial class Form1 : Form
    {
        List<ProiectPaw_CasaDeSchimbValutar.Modele.Tranzacite> listaTranzactii = new List<ProiectPaw_CasaDeSchimbValutar.Modele.Tranzacite>();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cbTipTranzactie.Items.Add("Cumparare");
            cbTipTranzactie.Items.Add("Vanzare");
            cbTipTranzactie.SelectedIndex = 0; // Selecteaza prima optiune din lista (Pentru nu a fi goala/alba)

            cbValuta.Items.Add("EUR - Euro");
            cbValuta.Items.Add("USD - Dolar American");
            cbValuta.Items.Add("GBP - Lira Sterlina");
            cbValuta.SelectedIndex = 0;
        }

        private void btnCalculeaza_Click(object sender, EventArgs e)
        {
            // Verific dacă ce s-a scris în TextBox-uri se poate transforma în numere (double) si daca sunt pozitive

            if (!double.TryParse(tbSuma.Text, out double suma) || suma <= 0)
            {
                MessageBox.Show("Te rog introdu o sumă validă (mai mare ca 0)!", "Eroare validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(tbCursCumparare.Text, out double cursCumparare) || cursCumparare <= 0)
            {
                MessageBox.Show("Te rog introdu un curs de cumpărare valid!", "Eroare validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(tbCursVanzare.Text, out double cursVanzare) || cursVanzare <= 0)
            {
                MessageBox.Show("Te rog introdu un curs de vânzare valid!", "Eroare validare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

       

            // Preiau tipul tranzacyiei ("Cumparare" sau "Vanzare") selectat în interfata
            string tipSelectat = cbTipTranzactie.SelectedItem.ToString();


            // Creez obiectele
            ProiectPaw_CasaDeSchimbValutar.Modele.Valuta valutaSelectata = new ProiectPaw_CasaDeSchimbValutar.Modele.Valuta(cbValuta.SelectedItem.ToString(), "");
            ProiectPaw_CasaDeSchimbValutar.Modele.CursValutar cursAplicat = new ProiectPaw_CasaDeSchimbValutar.Modele.CursValutar(valutaSelectata, DateTime.Now, cursCumparare, cursVanzare);

            // Creez tranzactia
            ProiectPaw_CasaDeSchimbValutar.Modele.Tranzacite tranzactieCurenta = new ProiectPaw_CasaDeSchimbValutar.Modele.Tranzacite(1, cursAplicat, suma, tipSelectat);

            double rezultat = tranzactieCurenta.CalculeazaSumaEliberata();
            tbRezultat.Text = Math.Round(rezultat, 2).ToString();
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(tbRezultat.Text))
            {
                MessageBox.Show("Te rog să calculezi întâi suma eliberată!", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //Preiau datele de pe ecran
            string valuta = cbValuta.SelectedItem.ToString();
            string tip = cbTipTranzactie.SelectedItem.ToString();
            double sumaIncasata = double.Parse(tbSuma.Text); // Folosim Parse pt ca stim deja ca datele sunt bune (le-am validat la calcul)
            double cursCumparare = double.Parse(tbCursCumparare.Text);
            double cursVanzare = double.Parse(tbCursVanzare.Text);
            double sumaEliberata = double.Parse(tbRezultat.Text);

           
            ProiectPaw_CasaDeSchimbValutar.Modele.Valuta v = new ProiectPaw_CasaDeSchimbValutar.Modele.Valuta(valuta, "");
            ProiectPaw_CasaDeSchimbValutar.Modele.CursValutar cv = new ProiectPaw_CasaDeSchimbValutar.Modele.CursValutar(v, DateTime.Now, cursCumparare, cursVanzare);
            ProiectPaw_CasaDeSchimbValutar.Modele.Tranzacite tranzactieNoua = new ProiectPaw_CasaDeSchimbValutar.Modele.Tranzacite(listaTranzactii.Count + 1, cv, sumaIncasata, tip);

            listaTranzactii.Add(tranzactieNoua);

     
            ListViewItem randNou = new ListViewItem(valuta);

       
            randNou.SubItems.Add(tip);
            randNou.SubItems.Add(sumaIncasata.ToString());

            
            if (tip == "Cumparare")
            {
                randNou.SubItems.Add(cursCumparare.ToString());
            }
            else
            {
                randNou.SubItems.Add(cursVanzare.ToString());
            }

            randNou.SubItems.Add(sumaEliberata.ToString());

            
            lvTranzactii.Items.Add(randNou);


            tbSuma.Clear();
            tbRezultat.Clear();
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            
            if (listaTranzactii.Count == 0)
            {
                MessageBox.Show("Nu există tranzacții de salvat!");
                return;
            }

            
            FileStream fisier = new FileStream("tranzactii.dat", FileMode.Create);

          
            BinaryFormatter serializator = new BinaryFormatter();

            
            serializator.Serialize(fisier, listaTranzactii);
            fisier.Close();

            MessageBox.Show("Datele au fost salvate cu succes!", "Salvare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIncarca_Click(object sender, EventArgs e)
        {
            
            if (!File.Exists("tranzactii.dat"))
            {
                MessageBox.Show("Fișierul cu date nu există încă!");
                return;
            }

            
            FileStream fisier = new FileStream("tranzactii.dat", FileMode.Open);
            BinaryFormatter deserializator = new BinaryFormatter();

            
            listaTranzactii = (List<ProiectPaw_CasaDeSchimbValutar.Modele.Tranzacite>)deserializator.Deserialize(fisier);
            fisier.Close();

            
            lvTranzactii.Items.Clear(); 

            foreach (ProiectPaw_CasaDeSchimbValutar.Modele.Tranzacite t in listaTranzactii)
            {
                
                ListViewItem rand = new ListViewItem(t.CursAplicat.Valuta.Cod);
                rand.SubItems.Add(t.TipTranzactie);
                rand.SubItems.Add(t.SumaIncasata.ToString());

                if (t.TipTranzactie == "Cumparare")
                    rand.SubItems.Add(t.CursAplicat.ValoareCumparare.ToString());
                else
                    rand.SubItems.Add(t.CursAplicat.ValoareVanzare.ToString());

                rand.SubItems.Add(t.CalculeazaSumaEliberata().ToString());

                lvTranzactii.Items.Add(rand);
            }

            MessageBox.Show("Datele au fost încărcate!", "Încărcare", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuIncarca_Click(object sender, EventArgs e)
        {
            btnIncarca.PerformClick();
        }

        private void salveazăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSalveaza.PerformClick();
        }

        private void menuIesire_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ștergeTranzacțiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvTranzactii.SelectedItems.Count > 0)
            {
                
                int index = lvTranzactii.SelectedItems[0].Index;

               
                lvTranzactii.Items.RemoveAt(index);

                
                listaTranzactii.RemoveAt(index);
            }
        }

        private void tbSuma_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                // e.Handled = true înseamnă "Am interceptat tasta, nu o lăsa să apara în TextBox"
                e.Handled = true;
            }

            // Prevenim introducerea a două virgule (ex: 12,5,3)
            if ((e.KeyChar == ',' || e.KeyChar == '.') && (sender as TextBox).Text.IndexOf(',') > -1)
            {
                e.Handled = true;
            }
        }

        private void afișeazăGraficToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrafic fereastraGrafic = new FormGrafic(listaTranzactii);

            
            fereastraGrafic.ShowDialog();
        }

        private void printeazăChitanțăToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (lvTranzactii.SelectedItems.Count > 0)
            {
                
                printPreviewDialog1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Te rog selectează o tranzacție din tabel pentru a-i printa chitanța!");
            }
        }

        private void pdChitanta_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            int indexSelectat = lvTranzactii.SelectedItems[0].Index;
            Modele.Tranzacite tranzactie = listaTranzactii[indexSelectat]; 

            
            Graphics g = e.Graphics;
            Font fontTitlu = new Font("Arial", 16, FontStyle.Bold);
            Font fontNormal = new Font("Arial", 12, FontStyle.Regular);
            Brush cerneala = Brushes.Black;

           
            int margineaStanga = 50;
            int y = 50; 

            
            g.DrawString("--- CASA DE SCHIMB VALUTAR ---", fontTitlu, cerneala, margineaStanga, y);
            y += 40; 

            g.DrawString("CHITANȚĂ TRANZACȚIE NR: " + tranzactie.idTranzacite, fontTitlu, cerneala, margineaStanga, y);
            y += 50;

            g.DrawString("Data și ora: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fontNormal, cerneala, margineaStanga, y);
            y += 30;

            g.DrawString("Tip Operațiune: " + tranzactie.TipTranzactie.ToUpper(), fontNormal, cerneala, margineaStanga, y);
            y += 30;

            g.DrawString("Valută: " + tranzactie.CursAplicat.Valuta.Cod, fontNormal, cerneala, margineaStanga, y);
            y += 30;

            g.DrawString("Suma Încasată: " + tranzactie.SumaIncasata, fontNormal, cerneala, margineaStanga, y);
            y += 30;

            
            string cursAfisat = tranzactie.TipTranzactie == "Cumparare" ?
                                tranzactie.CursAplicat.ValoareCumparare.ToString() :
                                tranzactie.CursAplicat.ValoareVanzare.ToString();

            g.DrawString("Curs Aplicat: " + cursAfisat, fontNormal, cerneala, margineaStanga, y);
            y += 40;

            
            g.DrawLine(new Pen(Color.Black, 2), margineaStanga, y, 400, y);
            y += 20;

            Font fontTotal = new Font("Arial", 14, FontStyle.Bold);
            g.DrawString("SUMA ELIBERATĂ: " + Math.Round(tranzactie.CalculeazaSumaEliberata(), 2), fontTotal, cerneala, margineaStanga, y);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
               
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
               
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] fisiere = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (fisiere.Length > 0)
            {
                string caleaFisierului = fisiere[0]; 

                try
                {
                    
                    string[] linii = System.IO.File.ReadAllLines(caleaFisierului);

                    
                    if (linii.Length >= 3)
                    {
                        tbSuma.Text = linii[0];
                        tbCursCumparare.Text = linii[1];
                        tbCursVanzare.Text = linii[2];

                        MessageBox.Show("Datele au fost importate cu succes din fișier!", "Drag & Drop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Fișierul nu conține suficiente date. Trebuie să aibă 3 linii (Sumă, CursCumpărare, CursVânzare).");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la citirea fișierului: " + ex.Message);
                }
            }
        }

        private void btnSalveazaBD_Click(object sender, EventArgs e)
        {
            if (listaTranzactii.Count == 0)
            {
                MessageBox.Show("Nu există tranzacții de salvat în baza de date!");
                return;
            }

            
            string connectionString = "Data Source=tranzactii.db;Version=3;";

            
            using (SQLiteConnection conexiune = new SQLiteConnection(connectionString))
            {
                conexiune.Open();

               
                string queryCreare = @"CREATE TABLE IF NOT EXISTS IstoricTranzactii (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                Valuta TEXT,
                                TipTranzactie TEXT,
                                SumaIncasata REAL,
                                SumaEliberata REAL)";

                using (SQLiteCommand cmdCreare = new SQLiteCommand(queryCreare, conexiune))
                {
                    cmdCreare.ExecuteNonQuery();
                }

                
                foreach (var t in listaTranzactii)
                {
                    string queryInsert = @"INSERT INTO IstoricTranzactii (Valuta, TipTranzactie, SumaIncasata, SumaEliberata) 
                                   VALUES (@valuta, @tip, @sumaIn, @sumaElib)";

                    using (SQLiteCommand cmdInsert = new SQLiteCommand(queryInsert, conexiune))
                    {
                        // Folosim parametri (cu @) - este standardul de aur pentru a preveni erorile de sintaxă sau SQL Injection
                        cmdInsert.Parameters.AddWithValue("@valuta", t.CursAplicat.Valuta.Cod);
                        cmdInsert.Parameters.AddWithValue("@tip", t.TipTranzactie);
                        cmdInsert.Parameters.AddWithValue("@sumaIn", t.SumaIncasata);
                        cmdInsert.Parameters.AddWithValue("@sumaElib", t.CalculeazaSumaEliberata());

                        cmdInsert.ExecuteNonQuery(); 
                    }
                }
            }

            MessageBox.Show("Datele au fost salvate cu succes în baza de date SQLite!", "Succes BD", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnIncarcaBD_Click(object sender, EventArgs e)
        {
            
            if (!System.IO.File.Exists("tranzactii.db"))
            {
                MessageBox.Show("Baza de date nu a fost creată încă!");
                return;
            }

            string connectionString = "Data Source=tranzactii.db;Version=3;";

            
            listaTranzactii.Clear();
            lvTranzactii.Items.Clear();

            using (SQLiteConnection conexiune = new SQLiteConnection(connectionString))
            {
                conexiune.Open();

                string querySelect = "SELECT * FROM IstoricTranzactii";
                using (SQLiteCommand cmdSelect = new SQLiteCommand(querySelect, conexiune))
                {
               
                    using (SQLiteDataReader reader = cmdSelect.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            string valuta = reader["Valuta"].ToString();
                            string tip = reader["TipTranzactie"].ToString();
                            double sumaIncasata = Convert.ToDouble(reader["SumaIncasata"]);
                            double sumaEliberata = Convert.ToDouble(reader["SumaEliberata"]);

                            
                            Modele.Valuta v = new Modele.Valuta(valuta, "");
                            Modele.CursValutar cv = new Modele.CursValutar(v, DateTime.Now, 0, 0);

                            
                            Modele.Tranzacite t = new Modele.Tranzacite(listaTranzactii.Count + 1, cv, sumaIncasata, tip);

                            listaTranzactii.Add(t);

                            
                            ListViewItem rand = new ListViewItem(valuta);
                            rand.SubItems.Add(tip);
                            rand.SubItems.Add(sumaIncasata.ToString());
                            rand.SubItems.Add("Din BD"); 
                            rand.SubItems.Add(sumaEliberata.ToString());
                            lvTranzactii.Items.Add(rand);
                        }
                    }
                }
            }

            MessageBox.Show("Datele au fost citite cu succes din baza de date!", "Încărcare BD", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}

