using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vjezbanje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRacunaj_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtPrviBroj.Text);
            int b = Convert.ToInt32(txtDrugiBroj.Text);
            int c = a + b;

            lblRezultat.Text = c.ToString();

            
        }

        private void btnBrojacSlova_Click(object sender, EventArgs e)
        {
            string rijec = txtStringUnos.Text;
            int brojZnakova = rijec.Length;
            int brojSamoglasnika = 0;

            for (int i = 0; i < brojZnakova; i++)
            {
                if (rijec[i] == 'A' || rijec[i] == 'a' || rijec[i] == 'E' || rijec[i] == 'e' || rijec[i] == 'I' || rijec[i] == 'i' || rijec[i] == 'O' || rijec[i] == 'o' || rijec[i] == 'U' || rijec[i] == 'u')
                {
                    brojSamoglasnika++;
                }
            }

            lblRezultatPrebrojavanja.Text = "Broj znakova u vašoj riječi/rečenici, uključujući razmak, je: " + brojZnakova + "\n" + "Broj samoglasnika u riječi/rečenici \"" + txtStringUnos.Text + "\" je: " + brojSamoglasnika.ToString();
        }

        private void btnSlucBr_Click(object sender, EventArgs e)
        {
            Random randomDvaBr = new Random();
            int[] nizrandomDvaBr = new int[2];

            for (int i = 0; i < 2; i++)
            {
                nizrandomDvaBr[i] = randomDvaBr.Next(0, 50);
            }
            // lblPrviSlucBr.Text = nizrandomDvaBr[0].ToString(); 
            // lblDrugiSlucBr.Text = nizrandomDvaBr[1].ToString();

            int a = Convert.ToInt32(lblPrviSlucBr.Text = nizrandomDvaBr[0].ToString());
            int b = Convert.ToInt32(lblDrugiSlucBr.Text = nizrandomDvaBr[1].ToString());
        }

        private void btnSlucBrUsp_Click(object sender, EventArgs e)
        {
            Random randomDvaBr = new Random();
            int[] nizrandomDvaBr = new int[2];

            for (int i = 0; i < 2; i++)
            {
                nizrandomDvaBr[i] = randomDvaBr.Next(0, 51);
            }
            int a = Convert.ToInt32(lblPrviSlucBr.Text = nizrandomDvaBr[0].ToString());
            int b = Convert.ToInt32(lblDrugiSlucBr.Text = nizrandomDvaBr[1].ToString()); 

            

            if (a > b)
            {
                lblRezUspSlucBr.Text = "Veći je broj: " + a;
            }
            else if (a < b)
            {
                lblRezUspSlucBr.Text = "Veći je broj: " + b;
            }
            else
            {
                lblRezUspSlucBr.Text = "Brojevi " + a + " i " + b + " su jednaki.";
            }
        }

        private void btnPokreniSluc_Click(object sender, EventArgs e)
        {
            Random rndBrojevi = new Random();
            int[] rndNizBrojeva = new int[2];

            for (int i = 0; i < 2; i++)
            {
                rndNizBrojeva[i] = rndBrojevi.Next(0, 51);
            }
            lblPrviSluc.Text = rndNizBrojeva[0].ToString();
            lblDrugiSluc.Text = rndNizBrojeva[1].ToString();

        }
    }
}
