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
    public partial class TitleScreenForm: Form
    {
        public TitleScreenForm()
        {
            InitializeComponent();
        }

        private void PicBoxStartButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
