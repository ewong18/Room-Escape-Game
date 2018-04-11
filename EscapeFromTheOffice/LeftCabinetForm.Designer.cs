namespace EscapeFromTheOffice
{
    partial class LeftCabinetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PicBoxKeyHole = new System.Windows.Forms.PictureBox();
            this.PicBoxGreenKeyItem = new System.Windows.Forms.PictureBox();
            this.PicBoxDownArrow = new System.Windows.Forms.PictureBox();
            this.PnlRoom = new System.Windows.Forms.Panel();
            this.PnlInventory = new System.Windows.Forms.Panel();
            this.RadBtnNone = new System.Windows.Forms.RadioButton();
            this.RadBtnGreenKey = new System.Windows.Forms.RadioButton();
            this.RadBtnRedKey = new System.Windows.Forms.RadioButton();
            this.RadBtnCabinetKey = new System.Windows.Forms.RadioButton();
            this.RadBtnCompOverlay = new System.Windows.Forms.RadioButton();
            this.RadBtnBatteries = new System.Windows.Forms.RadioButton();
            this.RadBtnShovel = new System.Windows.Forms.RadioButton();
            this.RadBtnChair = new System.Windows.Forms.RadioButton();
            this.RadBtnScrewdriver = new System.Windows.Forms.RadioButton();
            this.PicBoxGreenKey = new System.Windows.Forms.PictureBox();
            this.PicBoxBatteries = new System.Windows.Forms.PictureBox();
            this.PicBoxRedKey = new System.Windows.Forms.PictureBox();
            this.PicBoxScrewdriver = new System.Windows.Forms.PictureBox();
            this.PicBoxCabinetKey = new System.Windows.Forms.PictureBox();
            this.PicBoxChair = new System.Windows.Forms.PictureBox();
            this.PicBoxShovel = new System.Windows.Forms.PictureBox();
            this.PicBoxCompOverlay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxKeyHole)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxGreenKeyItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDownArrow)).BeginInit();
            this.PnlRoom.SuspendLayout();
            this.PnlInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxGreenKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBatteries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxRedKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxScrewdriver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCabinetKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxChair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxShovel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCompOverlay)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBoxKeyHole
            // 
            this.PicBoxKeyHole.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxKeyHole.Location = new System.Drawing.Point(522, 233);
            this.PicBoxKeyHole.Name = "PicBoxKeyHole";
            this.PicBoxKeyHole.Size = new System.Drawing.Size(93, 78);
            this.PicBoxKeyHole.TabIndex = 0;
            this.PicBoxKeyHole.TabStop = false;
            this.PicBoxKeyHole.Click += new System.EventHandler(this.PicBoxKeyHole_Click);
            // 
            // PicBoxGreenKeyItem
            // 
            this.PicBoxGreenKeyItem.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxGreenKeyItem.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.Green_Key;
            this.PicBoxGreenKeyItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxGreenKeyItem.Location = new System.Drawing.Point(378, 317);
            this.PicBoxGreenKeyItem.Name = "PicBoxGreenKeyItem";
            this.PicBoxGreenKeyItem.Size = new System.Drawing.Size(161, 69);
            this.PicBoxGreenKeyItem.TabIndex = 1;
            this.PicBoxGreenKeyItem.TabStop = false;
            this.PicBoxGreenKeyItem.Click += new System.EventHandler(this.PicBoxGreenKeyItem_Click);
            // 
            // PicBoxDownArrow
            // 
            this.PicBoxDownArrow.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxDownArrow.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.Down_Arrow;
            this.PicBoxDownArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxDownArrow.Location = new System.Drawing.Point(444, 469);
            this.PicBoxDownArrow.Name = "PicBoxDownArrow";
            this.PicBoxDownArrow.Size = new System.Drawing.Size(50, 50);
            this.PicBoxDownArrow.TabIndex = 2;
            this.PicBoxDownArrow.TabStop = false;
            this.PicBoxDownArrow.Click += new System.EventHandler(this.PicBoxDownArrow_Click);
            // 
            // PnlRoom
            // 
            this.PnlRoom.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.Left_Drawer_Closeup;
            this.PnlRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlRoom.Controls.Add(this.PicBoxDownArrow);
            this.PnlRoom.Controls.Add(this.PicBoxKeyHole);
            this.PnlRoom.Controls.Add(this.PicBoxGreenKeyItem);
            this.PnlRoom.Location = new System.Drawing.Point(-5, 110);
            this.PnlRoom.Name = "PnlRoom";
            this.PnlRoom.Size = new System.Drawing.Size(960, 540);
            this.PnlRoom.TabIndex = 3;
            // 
            // PnlInventory
            // 
            this.PnlInventory.BackColor = System.Drawing.Color.SaddleBrown;
            this.PnlInventory.Controls.Add(this.RadBtnNone);
            this.PnlInventory.Controls.Add(this.RadBtnGreenKey);
            this.PnlInventory.Controls.Add(this.RadBtnRedKey);
            this.PnlInventory.Controls.Add(this.RadBtnCabinetKey);
            this.PnlInventory.Controls.Add(this.RadBtnCompOverlay);
            this.PnlInventory.Controls.Add(this.RadBtnBatteries);
            this.PnlInventory.Controls.Add(this.RadBtnShovel);
            this.PnlInventory.Controls.Add(this.RadBtnChair);
            this.PnlInventory.Controls.Add(this.RadBtnScrewdriver);
            this.PnlInventory.Controls.Add(this.PicBoxGreenKey);
            this.PnlInventory.Controls.Add(this.PicBoxBatteries);
            this.PnlInventory.Controls.Add(this.PicBoxRedKey);
            this.PnlInventory.Controls.Add(this.PicBoxScrewdriver);
            this.PnlInventory.Controls.Add(this.PicBoxCabinetKey);
            this.PnlInventory.Controls.Add(this.PicBoxChair);
            this.PnlInventory.Controls.Add(this.PicBoxShovel);
            this.PnlInventory.Controls.Add(this.PicBoxCompOverlay);
            this.PnlInventory.Location = new System.Drawing.Point(0, 0);
            this.PnlInventory.Name = "PnlInventory";
            this.PnlInventory.Size = new System.Drawing.Size(952, 129);
            this.PnlInventory.TabIndex = 13;
            // 
            // RadBtnNone
            // 
            this.RadBtnNone.AutoSize = true;
            this.RadBtnNone.Checked = true;
            this.RadBtnNone.Location = new System.Drawing.Point(8, 44);
            this.RadBtnNone.Name = "RadBtnNone";
            this.RadBtnNone.Size = new System.Drawing.Size(14, 13);
            this.RadBtnNone.TabIndex = 19;
            this.RadBtnNone.TabStop = true;
            this.RadBtnNone.UseVisualStyleBackColor = true;
            this.RadBtnNone.Visible = false;
            // 
            // RadBtnGreenKey
            // 
            this.RadBtnGreenKey.AutoSize = true;
            this.RadBtnGreenKey.BackColor = System.Drawing.SystemColors.Control;
            this.RadBtnGreenKey.Location = new System.Drawing.Point(826, 15);
            this.RadBtnGreenKey.Name = "RadBtnGreenKey";
            this.RadBtnGreenKey.Size = new System.Drawing.Size(14, 13);
            this.RadBtnGreenKey.TabIndex = 18;
            this.RadBtnGreenKey.UseVisualStyleBackColor = false;
            this.RadBtnGreenKey.CheckedChanged += new System.EventHandler(this.RadBtnGreenKey_CheckedChanged);
            // 
            // RadBtnRedKey
            // 
            this.RadBtnRedKey.AutoSize = true;
            this.RadBtnRedKey.BackColor = System.Drawing.SystemColors.Control;
            this.RadBtnRedKey.Location = new System.Drawing.Point(715, 16);
            this.RadBtnRedKey.Name = "RadBtnRedKey";
            this.RadBtnRedKey.Size = new System.Drawing.Size(14, 13);
            this.RadBtnRedKey.TabIndex = 17;
            this.RadBtnRedKey.UseVisualStyleBackColor = false;
            this.RadBtnRedKey.CheckedChanged += new System.EventHandler(this.RadBtnRedKey_CheckedChanged);
            // 
            // RadBtnCabinetKey
            // 
            this.RadBtnCabinetKey.AutoSize = true;
            this.RadBtnCabinetKey.BackColor = System.Drawing.SystemColors.Control;
            this.RadBtnCabinetKey.Location = new System.Drawing.Point(601, 16);
            this.RadBtnCabinetKey.Name = "RadBtnCabinetKey";
            this.RadBtnCabinetKey.Size = new System.Drawing.Size(14, 13);
            this.RadBtnCabinetKey.TabIndex = 16;
            this.RadBtnCabinetKey.UseVisualStyleBackColor = false;
            this.RadBtnCabinetKey.CheckedChanged += new System.EventHandler(this.RadBtnCabinetKey_CheckedChanged);
            // 
            // RadBtnCompOverlay
            // 
            this.RadBtnCompOverlay.AutoSize = true;
            this.RadBtnCompOverlay.BackColor = System.Drawing.SystemColors.Control;
            this.RadBtnCompOverlay.Location = new System.Drawing.Point(488, 15);
            this.RadBtnCompOverlay.Name = "RadBtnCompOverlay";
            this.RadBtnCompOverlay.Size = new System.Drawing.Size(14, 13);
            this.RadBtnCompOverlay.TabIndex = 15;
            this.RadBtnCompOverlay.UseVisualStyleBackColor = false;
            this.RadBtnCompOverlay.CheckedChanged += new System.EventHandler(this.RadBtnCompOverlay_CheckedChanged);
            // 
            // RadBtnBatteries
            // 
            this.RadBtnBatteries.AutoSize = true;
            this.RadBtnBatteries.BackColor = System.Drawing.SystemColors.Control;
            this.RadBtnBatteries.Location = new System.Drawing.Point(147, 16);
            this.RadBtnBatteries.Name = "RadBtnBatteries";
            this.RadBtnBatteries.Size = new System.Drawing.Size(14, 13);
            this.RadBtnBatteries.TabIndex = 11;
            this.RadBtnBatteries.UseVisualStyleBackColor = false;
            this.RadBtnBatteries.CheckedChanged += new System.EventHandler(this.RadBtnBatteries_CheckedChanged);
            // 
            // RadBtnShovel
            // 
            this.RadBtnShovel.AutoSize = true;
            this.RadBtnShovel.BackColor = System.Drawing.SystemColors.Control;
            this.RadBtnShovel.Location = new System.Drawing.Point(373, 16);
            this.RadBtnShovel.Name = "RadBtnShovel";
            this.RadBtnShovel.Size = new System.Drawing.Size(14, 13);
            this.RadBtnShovel.TabIndex = 14;
            this.RadBtnShovel.UseVisualStyleBackColor = false;
            this.RadBtnShovel.CheckedChanged += new System.EventHandler(this.RadBtnShovel_CheckedChanged);
            // 
            // RadBtnChair
            // 
            this.RadBtnChair.AutoSize = true;
            this.RadBtnChair.BackColor = System.Drawing.SystemColors.Control;
            this.RadBtnChair.Location = new System.Drawing.Point(256, 15);
            this.RadBtnChair.Name = "RadBtnChair";
            this.RadBtnChair.Size = new System.Drawing.Size(14, 13);
            this.RadBtnChair.TabIndex = 13;
            this.RadBtnChair.UseVisualStyleBackColor = false;
            this.RadBtnChair.CheckedChanged += new System.EventHandler(this.RadBtnChair_CheckedChanged);
            // 
            // RadBtnScrewdriver
            // 
            this.RadBtnScrewdriver.AutoSize = true;
            this.RadBtnScrewdriver.BackColor = System.Drawing.SystemColors.Control;
            this.RadBtnScrewdriver.Location = new System.Drawing.Point(32, 16);
            this.RadBtnScrewdriver.Name = "RadBtnScrewdriver";
            this.RadBtnScrewdriver.Size = new System.Drawing.Size(14, 13);
            this.RadBtnScrewdriver.TabIndex = 4;
            this.RadBtnScrewdriver.UseVisualStyleBackColor = false;
            this.RadBtnScrewdriver.CheckedChanged += new System.EventHandler(this.RadBtnScrewdriver_CheckedChanged);
            // 
            // PicBoxGreenKey
            // 
            this.PicBoxGreenKey.BackColor = System.Drawing.SystemColors.Control;
            this.PicBoxGreenKey.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.Green_Key;
            this.PicBoxGreenKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicBoxGreenKey.Location = new System.Drawing.Point(824, 13);
            this.PicBoxGreenKey.Name = "PicBoxGreenKey";
            this.PicBoxGreenKey.Size = new System.Drawing.Size(80, 80);
            this.PicBoxGreenKey.TabIndex = 9;
            this.PicBoxGreenKey.TabStop = false;
            this.PicBoxGreenKey.Click += new System.EventHandler(this.PicBoxGreenKey_Click);
            // 
            // PicBoxBatteries
            // 
            this.PicBoxBatteries.BackColor = System.Drawing.SystemColors.Control;
            this.PicBoxBatteries.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.Batteries;
            this.PicBoxBatteries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicBoxBatteries.Location = new System.Drawing.Point(144, 13);
            this.PicBoxBatteries.Name = "PicBoxBatteries";
            this.PicBoxBatteries.Size = new System.Drawing.Size(80, 80);
            this.PicBoxBatteries.TabIndex = 3;
            this.PicBoxBatteries.TabStop = false;
            this.PicBoxBatteries.Click += new System.EventHandler(this.PicBoxBatteries_Click);
            // 
            // PicBoxRedKey
            // 
            this.PicBoxRedKey.BackColor = System.Drawing.SystemColors.Control;
            this.PicBoxRedKey.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.Red_Key;
            this.PicBoxRedKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicBoxRedKey.Location = new System.Drawing.Point(712, 13);
            this.PicBoxRedKey.Name = "PicBoxRedKey";
            this.PicBoxRedKey.Size = new System.Drawing.Size(80, 80);
            this.PicBoxRedKey.TabIndex = 8;
            this.PicBoxRedKey.TabStop = false;
            this.PicBoxRedKey.Click += new System.EventHandler(this.PicBoxRedKey_Click);
            // 
            // PicBoxScrewdriver
            // 
            this.PicBoxScrewdriver.BackColor = System.Drawing.SystemColors.Control;
            this.PicBoxScrewdriver.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.Screwdriver_Inventory;
            this.PicBoxScrewdriver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicBoxScrewdriver.Location = new System.Drawing.Point(29, 13);
            this.PicBoxScrewdriver.Name = "PicBoxScrewdriver";
            this.PicBoxScrewdriver.Size = new System.Drawing.Size(80, 80);
            this.PicBoxScrewdriver.TabIndex = 2;
            this.PicBoxScrewdriver.TabStop = false;
            this.PicBoxScrewdriver.Click += new System.EventHandler(this.PicBoxScrewdriver_Click);
            // 
            // PicBoxCabinetKey
            // 
            this.PicBoxCabinetKey.BackColor = System.Drawing.SystemColors.Control;
            this.PicBoxCabinetKey.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.Key;
            this.PicBoxCabinetKey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicBoxCabinetKey.Location = new System.Drawing.Point(598, 13);
            this.PicBoxCabinetKey.Name = "PicBoxCabinetKey";
            this.PicBoxCabinetKey.Size = new System.Drawing.Size(80, 80);
            this.PicBoxCabinetKey.TabIndex = 7;
            this.PicBoxCabinetKey.TabStop = false;
            this.PicBoxCabinetKey.Click += new System.EventHandler(this.PicBoxCabinetKey_Click);
            // 
            // PicBoxChair
            // 
            this.PicBoxChair.BackColor = System.Drawing.SystemColors.Control;
            this.PicBoxChair.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.Chair;
            this.PicBoxChair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicBoxChair.Location = new System.Drawing.Point(253, 13);
            this.PicBoxChair.Name = "PicBoxChair";
            this.PicBoxChair.Size = new System.Drawing.Size(80, 80);
            this.PicBoxChair.TabIndex = 4;
            this.PicBoxChair.TabStop = false;
            this.PicBoxChair.Click += new System.EventHandler(this.PicBoxChair_Click);
            // 
            // PicBoxShovel
            // 
            this.PicBoxShovel.BackColor = System.Drawing.SystemColors.Control;
            this.PicBoxShovel.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.Shovel_Inventory;
            this.PicBoxShovel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicBoxShovel.Location = new System.Drawing.Point(371, 13);
            this.PicBoxShovel.Name = "PicBoxShovel";
            this.PicBoxShovel.Size = new System.Drawing.Size(80, 80);
            this.PicBoxShovel.TabIndex = 5;
            this.PicBoxShovel.TabStop = false;
            this.PicBoxShovel.Click += new System.EventHandler(this.PicBoxShovel_Click);
            // 
            // PicBoxCompOverlay
            // 
            this.PicBoxCompOverlay.BackColor = System.Drawing.SystemColors.Control;
            this.PicBoxCompOverlay.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.TV_Overlay1;
            this.PicBoxCompOverlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PicBoxCompOverlay.Location = new System.Drawing.Point(485, 13);
            this.PicBoxCompOverlay.Name = "PicBoxCompOverlay";
            this.PicBoxCompOverlay.Size = new System.Drawing.Size(80, 80);
            this.PicBoxCompOverlay.TabIndex = 6;
            this.PicBoxCompOverlay.TabStop = false;
            this.PicBoxCompOverlay.Click += new System.EventHandler(this.PicBoxCompOverlay_Click);
            // 
            // LeftCabinetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 641);
            this.Controls.Add(this.PnlRoom);
            this.Controls.Add(this.PnlInventory);
            this.DoubleBuffered = true;
            this.Name = "LeftCabinetForm";
            this.Load += new System.EventHandler(this.LeftCabinetForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxKeyHole)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxGreenKeyItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDownArrow)).EndInit();
            this.PnlRoom.ResumeLayout(false);
            this.PnlInventory.ResumeLayout(false);
            this.PnlInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxGreenKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBatteries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxRedKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxScrewdriver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCabinetKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxChair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxShovel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCompOverlay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxKeyHole;
        private System.Windows.Forms.PictureBox PicBoxGreenKeyItem;
        private System.Windows.Forms.PictureBox PicBoxDownArrow;
        private System.Windows.Forms.Panel PnlRoom;
        private System.Windows.Forms.Panel PnlInventory;
        private System.Windows.Forms.RadioButton RadBtnNone;
        private System.Windows.Forms.RadioButton RadBtnGreenKey;
        private System.Windows.Forms.RadioButton RadBtnRedKey;
        private System.Windows.Forms.RadioButton RadBtnCabinetKey;
        private System.Windows.Forms.RadioButton RadBtnCompOverlay;
        private System.Windows.Forms.RadioButton RadBtnBatteries;
        private System.Windows.Forms.RadioButton RadBtnShovel;
        private System.Windows.Forms.RadioButton RadBtnChair;
        private System.Windows.Forms.RadioButton RadBtnScrewdriver;
        private System.Windows.Forms.PictureBox PicBoxGreenKey;
        private System.Windows.Forms.PictureBox PicBoxBatteries;
        private System.Windows.Forms.PictureBox PicBoxRedKey;
        private System.Windows.Forms.PictureBox PicBoxScrewdriver;
        private System.Windows.Forms.PictureBox PicBoxCabinetKey;
        private System.Windows.Forms.PictureBox PicBoxChair;
        private System.Windows.Forms.PictureBox PicBoxShovel;
        private System.Windows.Forms.PictureBox PicBoxCompOverlay;
    }
}
