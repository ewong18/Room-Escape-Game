namespace EscapeFromTheOffice
{
    partial class SofaCloseUpForm
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
            this.PicBoxCompOverlaySlip = new System.Windows.Forms.PictureBox();
            this.PicBoxCompOverlay = new System.Windows.Forms.PictureBox();
            this.PicBoxDownArrow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCompOverlaySlip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCompOverlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDownArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBoxCompOverlaySlip
            // 
            this.PicBoxCompOverlaySlip.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxCompOverlaySlip.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.TV_Clue_Slip;
            this.PicBoxCompOverlaySlip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxCompOverlaySlip.Location = new System.Drawing.Point(384, 509);
            this.PicBoxCompOverlaySlip.Name = "PicBoxCompOverlaySlip";
            this.PicBoxCompOverlaySlip.Size = new System.Drawing.Size(100, 100);
            this.PicBoxCompOverlaySlip.TabIndex = 0;
            this.PicBoxCompOverlaySlip.TabStop = false;
            this.PicBoxCompOverlaySlip.Click += new System.EventHandler(this.PicBoxCompOverlaySlip_Click);
            // 
            // PicBoxCompOverlay
            // 
            this.PicBoxCompOverlay.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxCompOverlay.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.TV_Overlay;
            this.PicBoxCompOverlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxCompOverlay.Location = new System.Drawing.Point(263, 160);
            this.PicBoxCompOverlay.Name = "PicBoxCompOverlay";
            this.PicBoxCompOverlay.Size = new System.Drawing.Size(503, 276);
            this.PicBoxCompOverlay.TabIndex = 1;
            this.PicBoxCompOverlay.TabStop = false;
            this.PicBoxCompOverlay.Click += new System.EventHandler(this.PicBoxCompOverlay_Click);
            // 
            // PicBoxDownArrow
            // 
            this.PicBoxDownArrow.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxDownArrow.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.Down_Arrow;
            this.PicBoxDownArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxDownArrow.Location = new System.Drawing.Point(501, 579);
            this.PicBoxDownArrow.Name = "PicBoxDownArrow";
            this.PicBoxDownArrow.Size = new System.Drawing.Size(50, 50);
            this.PicBoxDownArrow.TabIndex = 2;
            this.PicBoxDownArrow.TabStop = false;
            this.PicBoxDownArrow.Click += new System.EventHandler(this.PicBoxDownArrow_Click);
            // 
            // SofaCloseUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.Sofa_CloseUp;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 641);
            this.Controls.Add(this.PicBoxDownArrow);
            this.Controls.Add(this.PicBoxCompOverlay);
            this.Controls.Add(this.PicBoxCompOverlaySlip);
            this.Name = "SofaCloseUpForm";
            this.Load += new System.EventHandler(this.SofaCloseUpForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCompOverlaySlip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxCompOverlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDownArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxCompOverlaySlip;
        private System.Windows.Forms.PictureBox PicBoxCompOverlay;
        private System.Windows.Forms.PictureBox PicBoxDownArrow;
    }
}