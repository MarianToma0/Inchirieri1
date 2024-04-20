using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inchirieri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Inițializare și afișare mașini
            AfiseazaMasini();
        }

        private void AfiseazaMasini()
        {
            // Lista de mașini
            List<Masina> masini = new List<Masina>
            {
                new Masina { Nume = "Dacia Logan" },
                new Masina { Nume = "Volkswagen Golf" },
                new Masina { Nume = "Ford Focus" }
            };

            List<int> ani = new List<int> { 2020, 2019, 2021 };

            List<decimal> preturi = new List<decimal> { 100, 150, 120 };

            List<bool> inchiriate = new List<bool> { false, true, false };

            // Afisare mașini în TextBox-uri
            for (int i = 0; i < masini.Count; i++)
            {
                TextBox textBoxNume = new TextBox
                {
                    Multiline = true,
                    ReadOnly = true,
                    Text = $"Nume: {masini[i].Nume}"
                };

                TextBox textBoxAn = new TextBox
                {
                    Multiline = true,
                    ReadOnly = true,
                    Text = $"An: {ani[i]}"
                };

                TextBox textBoxPret = new TextBox
                {
                    Multiline = true,
                    ReadOnly = true,
                    Text = $"Preț: {preturi[i]} lei/zi"
                };

                TextBox textBoxInchiriata = new TextBox
                {
                    Multiline = true,
                    ReadOnly = true,
                    Text = $"Stare: {(inchiriate[i] ? "Închiriată" : "Disponibilă")}"
                };

                // Adăugare TextBox-uri la formular
                flowLayoutPanel1.Controls.Add(textBoxNume);
                flowLayoutPanel1.Controls.Add(textBoxAn);
                flowLayoutPanel1.Controls.Add(textBoxPret);
                flowLayoutPanel1.Controls.Add(textBoxInchiriata);
            }
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
    }
}

