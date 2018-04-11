namespace EscapeFromTheOffice
{
    partial class WindowZoomForm
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
            this.PicBoxShovel = new System.Windows.Forms.PictureBox();
            this.PicBoxDownArrow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxShovel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDownArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBoxShovel
            // 
            this.PicBoxShovel.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxShovel.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.Shovel;
            this.PicBoxShovel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxShovel.Location = new System.Drawing.Point(300, 383);
            this.PicBoxShovel.Name = "PicBoxShovel";
            this.PicBoxShovel.Size = new System.Drawing.Size(392, 92);
            this.PicBoxShovel.TabIndex = 0;
            this.PicBoxShovel.TabStop = false;
            this.PicBoxShovel.Click += new System.EventHandler(this.PicBoxShovel_Click);
            // 
            // PicBoxDownArrow
            // 
            this.PicBoxDownArrow.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxDownArrow.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.Down_Arrow;
            this.PicBoxDownArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxDownArrow.Location = new System.Drawing.Point(447, 551);
            this.PicBoxDownArrow.Name = "PicBoxDownArrow";
            this.PicBoxDownArrow.Size = new System.Drawing.Size(50, 50);
            this.PicBoxDownArrow.TabIndex = 1;
            this.PicBoxDownArrow.TabStop = false;
            this.PicBoxDownArrow.Click += new System.EventHandler(this.PicBoxDownArrow_Click);
            // 
            // WindowZoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.Window_CloseUp;
            this.ClientSize = new System.Drawing.Size(944, 641);
            this.Controls.Add(this.PicBoxDownArrow);
            this.Controls.Add(this.PicBoxShovel);
            this.Name = "WindowZoomForm";
            this.Text = "WindowZoom";
            this.Load += new System.EventHandler(this.WindowZoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxShovel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDownArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxShovel;
        private System.Windows.Forms.PictureBox PicBoxDownArrow;
    }
}