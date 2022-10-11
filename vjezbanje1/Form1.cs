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

        void Assign()
        {
            int x = Convert.ToInt32(txtValueX.Text);
            int y = Convert.ToInt32(txtValueY.Text);

            
            Assignment1(x, y);
            Assignment2(x, y);
            Assignment3(x, y);
            Assignment4(x, y);
            Assignment5(x, y);
            Assignment6(x, y);
            Assignment7(x, y);
            Assignment8(x, y);
            Assignment9(x, y);
            Assignment10(x, y);
        }

        void Assignment1(double first, double second)
        {
            
            lblReturnValue.Text += first + " += " + second + " ---> return value: ";
            double a = first += second;
            lblReturnValue.Text += a + "\n";
        }

        void Assignment2(double first, double second)
        {

            lblReturnValue.Text += first + " -= " + second + " ---> return value: ";
            double b = first -= second;
            lblReturnValue.Text += b + "\n";
        }

        void Assignment3(double first, double second)
        {

            lblReturnValue.Text += first + " *= " + second + " ---> return value: ";
            double c = first *= second;
            lblReturnValue.Text += c + "\n";
        }
        void Assignment4(double first, double second)
        {

            lblReturnValue.Text += first + " /= " + second + " ---> return value: ";
            double d = first /= second;
            lblReturnValue.Text += d + "\n";
        }
        void Assignment5(double first, double second)
        {

            lblReturnValue.Text += first + " %= " + second + " ---> return value: ";
            double e = first %= second;
            lblReturnValue.Text += e + "\n";
        }

        void Assignment6(int first, int second)
        {

            lblReturnValue.Text += first + " &&= " + second + " ---> return value: ";
            double f = first &= second;
            lblReturnValue.Text += f + "\n";
        }
        void Assignment7(int first, int second)
        {

            lblReturnValue.Text += first + " |= " + second + " ---> return value: ";
            double g = first |= second;
            lblReturnValue.Text += g + "\n";
        }
        void Assignment8(int first, int second)
        {

            lblReturnValue.Text += first + " ^= " + second + " ---> return value: ";
            double h = first ^= second;
            lblReturnValue.Text += h + "\n";
        }
        void Assignment9(int first, int second)
        {

            lblReturnValue.Text += first + " >>= " + second + " ---> return value: ";
            double i = first >>= second;
            lblReturnValue.Text += i + "\n";
        }
        void Assignment10(int first, int second)
        {

            lblReturnValue.Text += first + " <<= " + second + " ---> return value: ";
            double j = first <<= second;
            lblReturnValue.Text += j + "\n";
        }
        private void btnAssignment_Click(object sender, EventArgs e)
        {
            Assign();
        }

        void Compare()
        {
            int x = Convert.ToInt32(txtValueX.Text);
            int y = Convert.ToInt32(txtValueY.Text);
            Comparison1(x, y);
            Comparison2(x, y);
            Comparison3(x, y);
            Comparison4(x, y);
            Comparison5(x, y);
            Comparison6(x, y);
        }

        void Comparison1(int first, int second)
        {
            lblComparison.Text += first + " == " + second + " ---> return value: ";
            bool a = first == second;
            lblComparison.Text += a + "\n";
        }
        void Comparison2(int first, int second)
        {
            lblComparison.Text += first + " != " + second + " ---> return value: ";
            bool b = first != second;
            lblComparison.Text += b + "\n";
        }
        void Comparison3(int first, int second)
        {
            lblComparison.Text += first + " > " + second + " ---> return value: ";
            bool c = first > second;
            lblComparison.Text += c + "\n";
        }
        void Comparison4(int first, int second)
        {
            lblComparison.Text += first + " < " + second + " ---> return value: ";
            bool d = first < second;
            lblComparison.Text += d + "\n";
        }
        void Comparison5(int first, int second)
        {
            lblComparison.Text += first + " >= " + second + " ---> return value: ";
            bool e = first >= second;
            lblComparison.Text += e + "\n";
        }
        void Comparison6(int first, int second)
        {
            lblComparison.Text += first + " <= " + second + " ---> return value: ";
            bool f = first <= second;
            lblComparison.Text += f + "\n";
        }
        private void btnComparison_Click(object sender, EventArgs e)
        {
            Compare();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int[] userInput = new int[5];
        int x = 0;

        private void btnSaveElement_Click(object sender, EventArgs e)
        {
            userInput[x] = Convert.ToInt32(txtInputNumber.Text);
            x++;
            txtInputNumber.Clear();
            txtInputNumber.Focus();

            
            

            if (x == userInput.Length)
            {
                lblInstruction1.Enabled = false;
                txtInputNumber.Enabled = false;
                btnSaveElement.Enabled = false;

               

                lblReturnResult.Text += "Inputs: " + ArrayElements(userInput) + "\n";
                ArrayMin(userInput);
                ArrayMax(userInput);
            }

        }

        static string ArrayElements(int[] userInput)
        {
            string arrayElements = "";
            for(int x = 0; x < userInput.Length; x++)
            {
                arrayElements += " " + userInput[x] + " ";
            }
            return arrayElements;
        }
        void ArrayMin(int[] userInput)
        {
            lblReturnResult.Text += "Lowest value: " + Convert.ToString(userInput.Min()) + "\n";
        }
        void ArrayMax(int[] userInput)
        {
            lblReturnResult.Text += "Highest value: " + Convert.ToString(userInput.Max()) + "\n";
        }

    }
}
