namespace EscapeFromTheOffice
{
    partial class ClockZoomForm
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
            this.PicBoxDownArrow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDownArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBoxDownArrow
            // 
            this.PicBoxDownArrow.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxDownArrow.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.Down_Arrow;
            this.PicBoxDownArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxDownArrow.Location = new System.Drawing.Point(452, 479);
            this.PicBoxDownArrow.Name = "PicBoxDownArrow";
            this.PicBoxDownArrow.Size = new System.Drawing.Size(50, 50);
            this.PicBoxDownArrow.TabIndex = 0;
            this.PicBoxDownArrow.TabStop = false;
            this.PicBoxDownArrow.Click += new System.EventHandler(this.PicBoxDownArrow_Click);
            // 
            // ClockZoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.Clock_Closeup;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(944, 541);
            this.Controls.Add(this.PicBoxDownArrow);
            this.DoubleBuffered = true;
            this.Name = "ClockZoomForm";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDownArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxDownArrow;
    }
}