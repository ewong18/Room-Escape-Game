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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        public static int roomView;

        //Chair
        public static Boolean hasChair, placedChair, isSelected_Chair;

        //Screwdriver
        public static Boolean hasScrewdriver, isSelected_Screwdriver;

        //Shovel
        public static Boolean hasShovel, isSelected_Shovel;

        //Computer Overlay Clue
        public static Boolean hasCompOverlay, isSelected_CompOverlay;

        //Batteries
        public static Boolean hasBatteries, isSelected_Batteries;

        //Cabinet Key
        public static Boolean hasCabinetKey, isSelected_CabinetKey;

        //Red Key
        public static Boolean hasRedKey, isSelected_RedKey;

        //Green Key
        public static Boolean hasGreenKey, isSelected_GreenKey;


//---Inventory Controls---

        private void PicBoxScrewdriver_Click(object sender, EventArgs e)
        {
            RadBtnScrewdriver.Checked = true;
        }

        private void RadBtnScrewdriver_CheckedChanged(object sender, EventArgs e)
        {
            if(hasScrewdriver)
            {
                isSelected_Screwdriver = RadBtnScrewdriver.Checked;
            }
        }

        private void PicBoxBatteries_Click(object sender, EventArgs e)
        {
            RadBtnBatteries.Checked = true;
        }

        private void RadBtnBatteries_CheckedChanged(object sender, EventArgs e)
        {
            if (hasBatteries)
            {
                isSelected_Batteries = RadBtnBatteries.Checked;
            }

        }

        private void PicBoxChair_Click(object sender, EventArgs e)
        {
            RadBtnChair.Checked = true;
        }

        private void RadBtnChair_CheckedChanged(object sender, EventArgs e)
        {
            if (hasChair)
            {
                isSelected_Chair = RadBtnChair.Checked;
            }
        }

        private void PicBoxShovel_Click(object sender, EventArgs e)
        {
            RadBtnShovel.Checked = true;
        }

        private void RadBtnShovel_CheckedChanged(object sender, EventArgs e)
        {
            if(hasShovel)
            {
                isSelected_Shovel = RadBtnShovel.Checked;
            }
        }

        private void PicBoxCompOverlay_Click(object sender, EventArgs e)
        {
            RadBtnCompOverlay.Checked = true;
        }

        private void RadBtnCompOverlay_CheckedChanged(object sender, EventArgs e)
        {
            if (hasCompOverlay)
            {
                isSelected_CompOverlay = RadBtnCompOverlay.Checked;
            }
        }

        private void PicBoxCabinetKey_Click(object sender, EventArgs e)
        {
            RadBtnCabinetKey.Checked = true;
        }

        private void RadBtnCabinetKey_CheckedChanged(object sender, EventArgs e)
        {
            if (hasCabinetKey)
            {
                isSelected_CabinetKey = RadBtnCabinetKey.Checked;
            }
        }

        private void PicBoxRedKey_Click(object sender, EventArgs e)
        {
            RadBtnRedKey.Checked = true;
        }

        private void RadBtnRedKey_CheckedChanged(object sender, EventArgs e)
        {
            if (hasRedKey)
            {
                isSelected_RedKey = RadBtnRedKey.Checked;
            }
        }

        private void PicBoxGreenKey_Click(object sender, EventArgs e)
        {
            RadBtnGreenKey.Checked = true;
        }

        private void RadBtnGreenKey_CheckedChanged(object sender, EventArgs e)
        {
            if (hasGreenKey)
            {
                isSelected_GreenKey = RadBtnGreenKey.Checked;
            }
        }

//--Zoom View Controls--

    //North Wall Controls
        private void PicBoxDoor_Click(object sender, EventArgs e)
        {
            DoorZoomForm doorZoom = new DoorZoomForm();
            doorZoom.ShowDialog();
        }

        private void PicBoxWindowZoom_Click(object sender, EventArgs e)
        {
            WindowZoomForm windowZoom = new WindowZoomForm();
            windowZoom.ShowDialog();
        }
        
        private void PicBoxPlant_Click(object sender, EventArgs e)
        {
            if(isSelected_Shovel)
            {
                PlantZoomForm plantZoom = new PlantZoomForm();
                plantZoom.ShowDialog();
            }

            else
            {
                MessageBox.Show("There's something hidden in the dirt. We need something to dig it out.");
            }
        }

    //West Wall Controls
        private void PicBoxSofaZoom_Click(object sender, EventArgs e)
        {
            SofaCloseUpForm sofaCloseUp = new SofaCloseUpForm();
            sofaCloseUp.ShowDialog();
        }

        private void PicBoxComputerZoom_Click(object sender, EventArgs e)
        {
           ComputerCloseUpForm computerCloseUp = new ComputerCloseUpForm();
           computerCloseUp.ShowDialog();
        }

        private void PicBoxDrawerZoom_Click(object sender, EventArgs e)
        {
            WestWallDrawerForm westWallDrawer = new WestWallDrawerForm();
            westWallDrawer.ShowDialog();
        }
    //South Wall Controls
        private void PicBoxPaintingZoom_Click(object sender, EventArgs e)
        {
            PaintingCloseUpForm paintingCloseUp = new PaintingCloseUpForm();
            paintingCloseUp.ShowDialog();
        }

        private void PicBoxChairSouth_Click(object sender, EventArgs e)
        {
            hasChair = true;
            ViewLoad();
        }
        
    //East Wall Controls
        private void PicBoxClockZoom_Click(object sender, EventArgs e)
        {
            if(placedChair)
            {
                ClockZoomForm clockZoom = new ClockZoomForm();
                clockZoom.ShowDialog();
            }
            else
            {
                MessageBox.Show("It's too high up. I can't read the time. Let's look for something to climb up on, so we can read the time.");
            }
        }
        
        private void PicBoxChairEast_Click(object sender, EventArgs e)
        {
            if(isSelected_Chair)
            {
                placedChair = true;
                ViewLoad();
            }
        }
        
        private void PicBoxCabinetLeftZoom_Click(object sender, EventArgs e)
        {
            LeftCabinetForm leftCabinetZoom = new LeftCabinetForm();
            leftCabinetZoom.ShowDialog();
        }
        
        private void PicBoxCabinetRightZoom_Click(object sender, EventArgs e)
        {
            RightCabinetForm rightCabinetZoom = new RightCabinetForm();
            rightCabinetZoom.ShowDialog();
        }
        
//--Navigation Arrows--
        private void PicBoxLeftArrow_Click(object sender, EventArgs e)
        {
            roomView = ((roomView++) % 4) + 1; //Shows 4 walls going to the left
            ViewLoad();
        }

        private void PicBoxRightArrow_Click(object sender, EventArgs e)
        {
            //Shows 4 walls going to the right
            if (roomView > 1 && roomView <= 4)
            {
                roomView--;
            }

            else if (roomView == 1)
            {
                roomView = 4;
            }

            ViewLoad();
        }

//--Form Loading--
        private void ViewLoad()
        {
            
            //Controls whether item shows in inventory
            if(hasScrewdriver)
            {
                PicBoxScrewdriver.BackgroundImage = Properties.Resources.Screwdriver_Inventory;
            }

            if(!hasScrewdriver)
            {
                PicBoxScrewdriver.BackgroundImage = null;
            }

            if(hasBatteries)
            {
                PicBoxBatteries.BackgroundImage = Properties.Resources.Batteries;
            }

            if(!hasBatteries)
            {
                PicBoxBatteries.BackgroundImage = null;
            }

            if(hasChair)
            {
                PicBoxChair.BackgroundImage = Properties.Resources.Chair;
            }

            if(!hasChair)
            {
                PicBoxChair.BackgroundImage = null;
            }

            if(hasShovel)
            {
                PicBoxShovel.BackgroundImage = Properties.Resources.Shovel_Inventory;
            }

            if(!hasShovel)
            {
                PicBoxShovel.BackgroundImage = null;
            }

            if(hasCompOverlay)
            {
                PicBoxCompOverlay.BackgroundImage = Properties.Resources.TV_Overlay1;
            }

            if(!hasCompOverlay)
            {
                PicBoxCompOverlay.BackgroundImage = null;
            }

            if(hasCabinetKey)
            {
                PicBoxCabinetKey.BackgroundImage = Properties.Resources.Key;
            }

            if(!hasCabinetKey)
            {
                PicBoxCabinetKey.BackgroundImage = null;
            }

            if(hasRedKey)
            {
                PicBoxRedKey.BackgroundImage = Properties.Resources.Red_Key;
            }

            if(!hasRedKey)
            {
                PicBoxRedKey.BackgroundImage = null;
            }

            if (hasGreenKey)
            {
                PicBoxGreenKey.BackgroundImage = Properties.Resources.Green_Key;
            }

            if (!hasGreenKey)
            {
                PicBoxGreenKey.BackgroundImage = null;
            }

            //Controls Visibility of Clickable Areas in Each View
            switch (roomView)
            {
                case 1: //North Wall
                    PnlRoom.BackgroundImage = Properties.Resources.North_Wall;
                    PicBoxWindowZoom.Visible = true;
                    PicBoxDoor.Visible = true;
                    PicBoxPlant.Visible = true;
                    PicBoxDrawerZoom.Visible = false;
                    PicBoxSofaZoom.Visible = false;
                    PicBoxComputerZoom.Visible = false;
                    PicBoxChairSouth.Visible = false;
                    PicBoxPaintingZoom.Visible = false;
                    PicBoxClockZoom.Visible = false;
                    PicBoxChairEast.Visible = false;
                    PicBoxCabinetRightZoom.Visible = false;
                    PicBoxCabinetLeftZoom.Visible = false;
                    break;

                case 2: //West Wall
                    PnlRoom.BackgroundImage = Properties.Resources.West_Wall;
                    PicBoxWindowZoom.Visible = false;
                    PicBoxDoor.Visible = false;
                    PicBoxPlant.Visible = false;
                    PicBoxDrawerZoom.Visible = true;
                    PicBoxSofaZoom.Visible = true;
                    PicBoxComputerZoom.Visible = true;
                    PicBoxChairSouth.Visible = false;
                    PicBoxPaintingZoom.Visible = false;
                    PicBoxClockZoom.Visible = false;
                    PicBoxChairEast.Visible = false;
                    PicBoxCabinetRightZoom.Visible = false;
                    PicBoxCabinetLeftZoom.Visible = false;
                    break;

                case 3: //South Wall
                    if (hasChair == false)
                    {
                        PnlRoom.BackgroundImage = Properties.Resources.South_Wall;
                        PicBoxWindowZoom.Visible = false;
                        PicBoxDoor.Visible = false;
                        PicBoxPlant.Visible = false;
                        PicBoxDrawerZoom.Visible = false;
                        PicBoxSofaZoom.Visible = false;
                        PicBoxComputerZoom.Visible = false;
                        PicBoxChairSouth.Visible = true;
                        PicBoxPaintingZoom.Visible = true;
                        PicBoxClockZoom.Visible = false;
                        PicBoxChairEast.Visible = false;
                        PicBoxCabinetRightZoom.Visible = false;
                        PicBoxCabinetLeftZoom.Visible = false;
                    }
                    else
                    {
                        PnlRoom.BackgroundImage = Properties.Resources.South_Wall_No_Chair;
                        PicBoxWindowZoom.Visible = false;
                        PicBoxDoor.Visible = false;
                        PicBoxPlant.Visible = false;
                        PicBoxDrawerZoom.Visible = false;
                        PicBoxSofaZoom.Visible = false;
                        PicBoxComputerZoom.Visible = false;
                        PicBoxChairSouth.Visible = false;
                        PicBoxPaintingZoom.Visible = true;
                        PicBoxClockZoom.Visible = false;
                        PicBoxChairEast.Visible = false;
                        PicBoxCabinetRightZoom.Visible = false;
                        PicBoxCabinetLeftZoom.Visible = false;
                    }
                    break;

                case 4: //East Wall
                    if (placedChair)
                    {
                        PnlRoom.BackgroundImage = Properties.Resources.East_Wall_With_Chair;
                        PicBoxWindowZoom.Visible = false;
                        PicBoxDoor.Visible = false;
                        PicBoxPlant.Visible = false;
                        PicBoxDrawerZoom.Visible = false;
                        PicBoxSofaZoom.Visible = false;
                        PicBoxComputerZoom.Visible = false;
                        PicBoxChairSouth.Visible = false;
                        PicBoxPaintingZoom.Visible = false;
                        PicBoxClockZoom.Visible = true;
                        PicBoxChairEast.Visible = false;
                        PicBoxCabinetRightZoom.Visible = true;
                        PicBoxCabinetLeftZoom.Visible = true;
                    }
                    else
                    {
                        PnlRoom.BackgroundImage = Properties.Resources.East_Wall_No_Chair;
                        PicBoxWindowZoom.Visible = false;
                        PicBoxDoor.Visible = false;
                        PicBoxPlant.Visible = false;
                        PicBoxDrawerZoom.Visible = false;
                        PicBoxSofaZoom.Visible = false;
                        PicBoxComputerZoom.Visible = false;
                        PicBoxChairSouth.Visible = false;
                        PicBoxPaintingZoom.Visible = false;
                        PicBoxClockZoom.Visible = true;
                        PicBoxChairEast.Visible = true;
                        PicBoxCabinetRightZoom.Visible = true;
                        PicBoxCabinetLeftZoom.Visible = true;
                    }
                    break;

            }
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            TitleScreenForm titleScreen = new TitleScreenForm();
            titleScreen.ShowDialog();
            roomView = 1;
            hasChair = false;
            placedChair = false;
            ViewLoad();
        }

private void MainForm_Activated(object sender, EventArgs e)
        {
            ViewLoad();
        }
    }
}
