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
    public partial class PaintingCloseUpForm : Form
    {
        public PaintingCloseUpForm()
        {
            InitializeComponent();
        }
        Boolean UpL_Unscrew, UpR_Unscrew, LowL_Unscrew, LowR_Unscrew;

        private void PicBoxScrewLowR_Click(object sender, EventArgs e)
        {
            if (MainForm.isSelected_Screwdriver)
            {
                LowR_Unscrew = true;
                PicBoxScrewLowR.Visible = false;
            }
        }

        private void PicBoxScrewUpR_Click(object sender, EventArgs e)
        {
            if (MainForm.isSelected_Screwdriver)
            {
                UpR_Unscrew = true;
                PicBoxScrewUpR.Visible = false;
            }
        }

        private void PicBoxLiftPainting_Click(object sender, EventArgs e)
        {
            if(UpL_Unscrew && LowL_Unscrew && LowR_Unscrew && UpR_Unscrew)
            {
                PnlRoom.BackgroundImage = Properties.Resources.Hole_in_Wall;
                PicBoxCabinetKeyItem.Visible = !MainForm.hasCabinetKey;
            }

            else
            {
                MessageBox.Show("We need to unscrew the painting from the wall.");
            }
        }

        private void PicBoxDownArrow_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PicBoxCabinetKeyItem_Click(object sender, EventArgs e)
        {
            MainForm.hasCabinetKey = true;
            PicBoxCabinetKeyItem.Visible = false;
            PicBoxCabinetKey.BackgroundImage = Properties.Resources.Key;
        }

        private void PicBoxScrewLowL_Click(object sender, EventArgs e)
        {
            if (MainForm.isSelected_Screwdriver)
            {
                LowL_Unscrew = true;
                PicBoxScrewLowL.Visible = false;
            }
        }

        private void PicBoxScrewUpL_Click(object sender, EventArgs e)
        {
            if(MainForm.isSelected_Screwdriver)
            {
                UpL_Unscrew = true;
                PicBoxScrewUpL.Visible = false;
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
        
        private void PaintingCloseUpForm_Load(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.Painting_Closeup;
            PicBoxCabinetKeyItem.Visible = false;
            
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
    }
}
