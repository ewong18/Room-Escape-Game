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
    public partial class PlantZoomForm : Form
    {
        public PlantZoomForm()
        {
            InitializeComponent();
        }

        private void PicBoxBatteries_Click(object sender, EventArgs e)
        {
            MainForm.hasBatteries = true;
            PicBoxBatteries.Visible = !MainForm.hasBatteries;
        }

        private void PlantZoomForm_Load(object sender, EventArgs e)
        {
            PicBoxBatteries.Visible = !MainForm.hasBatteries;
        }

        private void PicBoxDownArrow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
