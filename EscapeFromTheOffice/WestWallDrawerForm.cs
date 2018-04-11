using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeFromTheOffice
{
    public partial class WestWallDrawerForm : Form
    {
        public WestWallDrawerForm()
        {
            InitializeComponent();
        }

        int lblNum1000 = 0;
        int lblNum100 = 0;
        int lblNum10 = 0;
        int lblNum1 = 0;

        private void PicBoxNumIncr1000_Click(object sender, EventArgs e)
        {
            if (int.TryParse(LblDrawer1000.Text, out lblNum1000))
            {
                LblDrawer1000.Text = NumIncrement(lblNum1000).ToString();
            }
        }

        private void PicBoxNumIncr100_Click(object sender, EventArgs e)
        {
            if (int.TryParse(LblDrawer100.Text, out lblNum100))
            {
                LblDrawer100.Text = NumIncrement(lblNum100).ToString();
            }
        }

        private void PicBoxNumIncr10_Click(object sender, EventArgs e)
        {
            if (int.TryParse(LblDrawer10.Text, out lblNum10))
            {
                LblDrawer10.Text = NumIncrement(lblNum10).ToString();
            }
        }

        private void PicBoxNumIncr1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(LblDrawer1.Text, out lblNum1))
            {
                LblDrawer1.Text = NumIncrement(lblNum1).ToString();
            }
        }

        private void PicBoxNumDecr1000_Click(object sender, EventArgs e)
        {
            if (int.TryParse(LblDrawer1000.Text, out lblNum1000))
            {
                LblDrawer1000.Text = NumDecrement(lblNum1000).ToString();
            }
        }

        private void PicBoxNumDecr100_Click(object sender, EventArgs e)
        {
            if (int.TryParse(LblDrawer100.Text, out lblNum100))
            {
                LblDrawer100.Text = NumDecrement(lblNum100).ToString();
            }
        }

        private void PicBoxNumDecr10_Click(object sender, EventArgs e)
        {
            if (int.TryParse(LblDrawer10.Text, out lblNum10))
            {
                LblDrawer10.Text = NumDecrement(lblNum10).ToString();
            }
        }

        private void PicBoxNumDecr1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(LblDrawer1.Text, out lblNum1))
            {
                LblDrawer1.Text = NumDecrement(lblNum1).ToString();
            }
        }

        private void PicBoxNumEnter_Click(object sender, EventArgs e)
        {
            //Opens if correct answer entered (22:07)
            //Clock clue is a bit ambiguous, also accepts 22:08 as an answer
            if(LblDrawer1000.Text.Equals("2") && LblDrawer100.Text.Equals("2") &&
                LblDrawer10.Text.Equals("0") && (LblDrawer1.Text.Equals("7") || LblDrawer1.Text.Equals("8")))
            {
                BackgroundImage = Properties.Resources.Open_West_Drawer;
                PicBoxNumIncr1000.Visible = false;
                PicBoxNumIncr100.Visible = false;
                PicBoxNumIncr10.Visible = false;
                PicBoxNumIncr1.Visible = false;
                PicBoxNumDecr1000.Visible = false;
                PicBoxNumDecr100.Visible = false;
                PicBoxNumDecr10.Visible = false;
                PicBoxNumDecr1.Visible = false;
                LblDrawer1000.Visible = false;
                LblDrawer100.Visible = false;
                LblColon.Visible = false;
                LblDrawer10.Visible = false;
                LblDrawer1.Visible = false;
                PicBoxNumEnter.Visible = false;
                PicBoxScrewdriver.Visible = !MainForm.hasScrewdriver;
            }

            else
            {
                MessageBox.Show("Check the clock for a clue.");
            }
        }

        private void PicBoxScrewdriver_Click(object sender, EventArgs e)
        {
            MainForm.hasScrewdriver = true;
            PicBoxScrewdriver.Visible = !MainForm.hasScrewdriver;
        }

        private void WestWallDrawerForm_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Drawer_Closeup;
            PicBoxNumIncr1000.Visible = true;
            PicBoxNumIncr100.Visible = true;
            PicBoxNumIncr10.Visible = true;
            PicBoxNumIncr1.Visible = true;
            PicBoxNumDecr1000.Visible = true;
            PicBoxNumDecr100.Visible = true;
            PicBoxNumDecr10.Visible = true;
            PicBoxNumDecr1.Visible = true;
            LblDrawer1000.Visible = true;
            LblDrawer100.Visible = true;
            LblColon.Visible = true;
            LblDrawer10.Visible = true;
            LblDrawer1.Visible = true;
            PicBoxNumEnter.Visible = true;
            PicBoxScrewdriver.Visible = false;
        }

        private int NumIncrement(int number)
        {
            if (number >= 0 && number < 9)
            {
                number++;
            }
            else if (number == 9)
            {
                number = 0;
            }

            return number;
        }

        private int NumDecrement(int number)
        {
            if (number > 0 && number <=9)
            {
                number--;
            }

            else if (number == 0)
            {
                number = 9;
            }

            return number;
        }
        private void PicBoxDownArrow_Click(object sender, EventArgs e)
        {
            if(!LblColon.Visible)
            {
                WestWallDrawerForm_Load(sender, e);
            }
            else
            {
                this.Close();
            }
        }

        //Allows user to also click on drawer handle to open drawer
        private void PicBoxDrawerHandle_Click(object sender, EventArgs e)
        {
            PicBoxNumEnter_Click(sender, e);
        }
    }
}
