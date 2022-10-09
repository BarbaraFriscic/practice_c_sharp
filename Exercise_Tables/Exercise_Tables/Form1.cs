using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise_Tables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Drawers()
        {
            int drawers = Convert.ToInt32(txtDrawrs.Text);
            return drawers;
        }

        public char WoodType()
        {
            char wood = Convert.ToChar(txtWoodType.Text);
            return wood;
        }

        public double OrderCosts(int drawers, char wood)
        {
            wood = WoodType();
            drawers = Drawers();
            int costOfWood;
            int costofDrawer = 30;
            double orderCost = 0;
            string woodType = "";

            if (wood == 'o' || wood == 'O')
            {
                woodType = "oak";
                costOfWood = 140;
                orderCost = costofDrawer * drawers + costOfWood;
            }
            else if (wood == 'p' || wood == 'P')
            {
                woodType = "pine";
                costOfWood = 100;
                orderCost = costofDrawer * drawers + costOfWood;

            }
            else if (wood == 'm' || wood == 'M')
            {
                woodType = "maple";
                costOfWood = 180;
                orderCost = costofDrawer * drawers + costOfWood;
            }
            return orderCost;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int drawers = Drawers();
            char wood = WoodType();
            string woodType = "";

            if (wood == 'o' || wood == 'O')
            {
                woodType = "oak";
            }
            else if (wood == 'p' || wood == 'P')
            {
                woodType = "pine";

            }
            else if (wood == 'm' || wood == 'M')
            {
                woodType = "maple";
            }

            lblOrderSummary.Text = "You ordered " + woodType + " table and " + Drawers() + " drawers." + "\n" + "The total cost is " + OrderCosts(drawers, wood) + " kn.";
        }
    }
}
