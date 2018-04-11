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
    public partial class SofaCloseUpForm : Form
    {
        public SofaCloseUpForm()
        {
            InitializeComponent();
        }

        private void SofaCloseUpForm_Load(object sender, EventArgs e)
        {
            PicBoxCompOverlaySlip.Visible = !MainForm.hasCompOverlay;
            BackgroundImage = Properties.Resources.Sofa_CloseUp;
            PicBoxCompOverlay.Visible = false;
        }

        private void PicBoxCompOverlaySlip_Click(object sender, EventArgs e)
        {
            MainForm.hasCompOverlay = true;
            PicBoxCompOverlaySlip.Visible = false;
            PicBoxCompOverlay.Visible = true;
        }

        //Hides TV Overlay or Closes Form if TV Overlay already hidden
        private void PicBoxDownArrow_Click(object sender, EventArgs e)
        {
            if(PicBoxCompOverlay.Visible)
            {
                PicBoxCompOverlay.Visible = false;
            }

            else
            {
                this.Close();
            }
        }

        private void PicBoxCompOverlay_Click(object sender, EventArgs e)
        {
            PicBoxCompOverlay.Visible = false; //Hides TV Overlay once clicked
        }
    }
}
