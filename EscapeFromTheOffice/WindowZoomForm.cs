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
    public partial class WindowZoomForm : Form
    {
        public WindowZoomForm()
        {
            InitializeComponent();
        }

        private void PicBoxDownArrow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicBoxShovel_Click(object sender, EventArgs e)
        {
            PicBoxShovel.Visible = false;
            MainForm.hasShovel = true;
        }

        private void WindowZoomForm_Load(object sender, EventArgs e)
        {
            PicBoxShovel.Visible = !MainForm.hasShovel;
        }
    }
}
