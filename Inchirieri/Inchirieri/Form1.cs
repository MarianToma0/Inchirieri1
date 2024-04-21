using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO; // Adăugată pentru lucrul cu fișiere
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inchirieri
{
    public partial class Form1 : Form
    {
        private const int MinAn = 1900;
        private readonly int MaxAn = DateTime.Now.Year;
        private const decimal MinPret = 0;
        
        



        public Form1()
        {
            InitializeComponent();

            // Inițializare și afișare mașini
            AfiseazaMasini();
        }

        private void AfiseazaMasini()
        {
            // Calea către fișierul de date
            string filePath = @"C:\Users\tomam\Desktop\Inchirieri\Inchirieri\Masini.txt";

            // Verifică dacă fișierul există
            if (!File.Exists(filePath))
            {
                // Creează fișierul dacă nu există
                File.Create(filePath).Close();  // Close() închide fișierul creat

                MessageBox.Show("Fișierul de date nu există și a fost creat!");
                return;
            }


            // Citirea datelor din fișier
            var lines = File.ReadAllLines(filePath);

            // Lista de mașini
            List<Masina> masini = new List<Masina>();

            foreach (var line in lines)
            {
                var parts = line.Split(',');
                if (parts.Length == 4)
                {
                    try
                    {
                        // Creare și adăugare mașină în listă
                        Masina masina = new Masina
                        {
                            Nume = parts[0],
                            An = int.Parse(parts[1]),
                            Pret = decimal.Parse(parts[2]),
                            Inchiriata = bool.Parse(parts[3])
                        };
                        masini.Add(masina);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Eroare la parsarea uneia dintre linii.");
                        return;
                    }
                }
            }

            // Afișare mașini în TextBox-uri
            foreach (var masina in masini)
            {
                AdaugaMasinaLaFormular(masina, masina.An, masina.Pret, masina.Inchiriata);
            }
        }

        private void AdaugaMasinaLaFormular(Masina masina, int an, decimal pret, bool inchiriata)
        {
            TextBox textBoxNume = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"Nume: {masina.Nume}"
            };

            TextBox textBoxAn = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"An: {an}"
            };

            TextBox textBoxPret = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"Preț: {pret} lei/zi"
            };

            TextBox textBoxInchiriata = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"Stare: {(inchiriata ? "Închiriată" : "Disponibilă")}"
            };

            // Adăugare TextBox-uri la formular
            flowLayoutPanel1.Controls.Add(textBoxNume);
            flowLayoutPanel1.Controls.Add(textBoxAn);
            flowLayoutPanel1.Controls.Add(textBoxPret);
            flowLayoutPanel1.Controls.Add(textBoxInchiriata);
        }

        private void ResetFields()
        {
            txtNume.Text = "";
            nudAn.Value = DateTime.Now.Year;
            nudPret.Value = 0;
            chkInchiriata.Checked = false;
        }

        public class Masina
        {
            public string Nume { get; set; }
            public int An { get; set; }
            public decimal Pret { get; set; }
            public bool Inchiriata { get; set; }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void nudAn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdaugaMasina_Click_1(object sender, EventArgs e)
        {
            // Validare nume
            if (string.IsNullOrWhiteSpace(txtNume.Text))
            {
                lblNume.ForeColor = Color.Red;
                lblNume.Text = "Nume: Introduceți un nume!";
                return;
            }

            // Validare an
            if (nudAn.Value < MinAn || nudAn.Value > MaxAn)
            {
                lblAn.ForeColor = Color.Red;
                lblAn.Text = $"An: Introduceți un an între {MinAn} și {MaxAn}!";
                return;
            }

            // Validare preț
            if (nudPret.Value <= MinPret)
            {
                lblPret.ForeColor = Color.Red;
                lblPret.Text = $"Preț: Introduceți un preț pozitiv!";
                return;
            }

            // Creare mașină
            Masina masina = new Masina
            {
                Nume = txtNume.Text,
                An = (int)nudAn.Value,
                Pret = nudPret.Value,
                Inchiriata = chkInchiriata.Checked
            };

            // Adăugare mașină în fișier
            AdaugaMasinaInFisier(masina);
            // Adăugare mașină la formular
            AdaugaMasinaLaFormular(masina, masina.An, masina.Pret, masina.Inchiriata);

            // Resetare câmpuri și etichete
            ResetFields();
        }
        private void AdaugaMasinaInFisier(Masina masina)
        {

            string filePath = @"C:\Users\tomam\Desktop\Inchirieri\Inchirieri\Masini.txt";
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"{masina.Nume},{masina.An},{masina.Pret},{masina.Inchiriata}");
            }
        }

        private void lblAn_Click(object sender, EventArgs e)
        {
            // Potențial cod pentru a trata evenimente specifice etichetei 'An'
        }

        private void lblNume_Click(object sender, EventArgs e)
        {
            // Potențial cod pentru a trata evenimente specifice etichetei 'Nume'
        }
    }
}
