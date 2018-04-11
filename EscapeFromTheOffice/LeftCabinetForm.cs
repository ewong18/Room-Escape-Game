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
    public partial class LeftCabinetForm : Form
    {
        public LeftCabinetForm()
        {
            InitializeComponent();
        }

        private void LeftCabinetForm_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Left_Drawer_Closeup;
            PicBoxKeyHole.Visible = true;
            PicBoxGreenKeyItem.Visible = false;
            
            //Controls whether item shows in inventory
            if(MainForm.hasScrewdriver)
            {
                PicBoxScrewdriver.BackgroundImage = Properties.Resources.Screwdriver_Inventory;
            }
            
            if(!MainForm.hasScrewdriver)
            {
                PicBoxScrewdriver.BackgroundImage = null;
            }
            
            if(MainForm.hasBatteries)
            {
                PicBoxBatteries.BackgroundImage = Properties.Resources.Batteries;
            }
            
            if(!MainForm.hasBatteries)
            {
                PicBoxBatteries.BackgroundImage = null;
            }
            
            if(MainForm.hasChair)
            {
                PicBoxChair.BackgroundImage = Properties.Resources.Chair;
            }
            
            if(!MainForm.hasChair)
            {
                PicBoxChair.BackgroundImage = null;
            }
            
            if(MainForm.hasShovel)
            {
                PicBoxShovel.BackgroundImage = Properties.Resources.Shovel_Inventory;
            }
            
            if(!MainForm.hasShovel)
            {
                PicBoxShovel.BackgroundImage = null;
            }
            
            if(MainForm.hasCompOverlay)
            {
                PicBoxCompOverlay.BackgroundImage = Properties.Resources.TV_Overlay1;
            }
            
            if(!MainForm.hasCompOverlay)
            {
                PicBoxCompOverlay.BackgroundImage = null;
            }
            
            if(MainForm.hasCabinetKey)
            {
                PicBoxCabinetKey.BackgroundImage = Properties.Resources.Key;
            }
            
            if(!MainForm.hasCabinetKey)
            {
                PicBoxCabinetKey.BackgroundImage = null;
            }
            
            if(MainForm.hasRedKey)
            {
                PicBoxRedKey.BackgroundImage = Properties.Resources.Red_Key;
            }
            
            if(!MainForm.hasRedKey)
            {
                PicBoxRedKey.BackgroundImage = null;
            }
            
            if (MainForm.hasGreenKey)
            {
                PicBoxGreenKey.BackgroundImage = Properties.Resources.Green_Key;
            }
            
            if (!MainForm.hasGreenKey)
            {
                PicBoxGreenKey.BackgroundImage = null;
            }
        }
        
        private void PicBoxKeyHole_Click(object sender, EventArgs e)
        {
            if(MainForm.isSelected_CabinetKey)
            {
                PnlRoom.BackgroundImage = Properties.Resources.Open_Left_Cabinet;
                PicBoxKeyHole.Visible = false;
                PicBoxGreenKeyItem.Visible = true;
            }
        }
       
        private void PicBoxGreenKeyItem_Click(object sender, EventArgs e)
        {
            MainForm.hasGreenKey = true;
            PicBoxGreenKeyItem.Visible = !MainForm.hasGreenKey;
            PicBoxGreenKey.BackgroundImage = Properties.Resources.Green_Key;
        }

        private void PicBoxDownArrow_Click(object sender, EventArgs e)
        {
            if(!PicBoxKeyHole.Visible)
            {
                LeftCabinetForm_Load(sender, e);
            }

            else
            {
                this.Close();
            }
        }
//--Inventory Controls--
        private void PicBoxScrewdriver_Click(object sender, EventArgs e)
        {
            RadBtnScrewdriver.Checked = true;
        }
        
        private void RadBtnScrewdriver_CheckedChanged(object sender, EventArgs e)
        {
            if(MainForm.hasScrewdriver)
            {
                MainForm.isSelected_Screwdriver = RadBtnScrewdriver.Checked;
            }
        }
        
        private void PicBoxBatteries_Click(object sender, EventArgs e)
        {
            RadBtnBatteries.Checked = true;
        }
        
        private void RadBtnBatteries_CheckedChanged(object sender, EventArgs e)
        {
            if (MainForm.hasBatteries)
            {
                MainForm.isSelected_Batteries = RadBtnBatteries.Checked;
            }
        }
        
        private void PicBoxChair_Click(object sender, EventArgs e)
        {
            RadBtnChair.Checked = true;
        }
        
        private void RadBtnChair_CheckedChanged(object sender, EventArgs e)
        {
            if (MainForm.hasChair)
            {
                MainForm.isSelected_Chair = RadBtnChair.Checked;
            }
        }
        
        private void PicBoxShovel_Click(object sender, EventArgs e)
        {
            RadBtnShovel.Checked = true;
        }
        
        private void RadBtnShovel_CheckedChanged(object sender, EventArgs e)
        {
            if(MainForm.hasShovel)
            {
                MainForm.isSelected_Shovel = RadBtnShovel.Checked;
            }
        }
        
        private void PicBoxCompOverlay_Click(object sender, EventArgs e)
        {
            RadBtnCompOverlay.Checked = true;
        }
        
        private void RadBtnCompOverlay_CheckedChanged(object sender, EventArgs e)
        {
            if (MainForm.hasCompOverlay)
            {
                MainForm.isSelected_CompOverlay = RadBtnCompOverlay.Checked;
            }
        }
        
        private void PicBoxCabinetKey_Click(object sender, EventArgs e)
        {
            RadBtnCabinetKey.Checked = true;
        }
        
        private void RadBtnCabinetKey_CheckedChanged(object sender, EventArgs e)
        {
            if (MainForm.hasCabinetKey)
            {
                MainForm.isSelected_CabinetKey = RadBtnCabinetKey.Checked;
            }
        }
        
        private void PicBoxRedKey_Click(object sender, EventArgs e)
        {
            RadBtnRedKey.Checked = true;
        }
        
        private void RadBtnRedKey_CheckedChanged(object sender, EventArgs e)
        {
            if (MainForm.hasRedKey)
            {
                MainForm.isSelected_RedKey = RadBtnRedKey.Checked;
            }
        }
        
        private void PicBoxGreenKey_Click(object sender, EventArgs e)
        {
            RadBtnGreenKey.Checked = true;
        }
        
        private void RadBtnGreenKey_CheckedChanged(object sender, EventArgs e)
        {
            if (MainForm.hasGreenKey)
            {
                MainForm.isSelected_GreenKey = RadBtnGreenKey.Checked;
            }
        }
    }
}
