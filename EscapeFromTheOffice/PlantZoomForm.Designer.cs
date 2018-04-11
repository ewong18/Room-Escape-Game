namespace EscapeFromTheOffice
{
    partial class PlantZoomForm
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
            this.PicBoxBatteries = new System.Windows.Forms.PictureBox();
            this.PicBoxDownArrow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBatteries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDownArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBoxBatteries
            // 
            this.PicBoxBatteries.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxBatteries.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.Batteries_on_Shovel;
            this.PicBoxBatteries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxBatteries.Location = new System.Drawing.Point(276, 295);
            this.PicBoxBatteries.Name = "PicBoxBatteries";
            this.PicBoxBatteries.Size = new System.Drawing.Size(175, 150);
            this.PicBoxBatteries.TabIndex = 0;
            this.PicBoxBatteries.TabStop = false;
            this.PicBoxBatteries.Click += new System.EventHandler(this.PicBoxBatteries_Click);
            // 
            // PicBoxDownArrow
            // 
            this.PicBoxDownArrow.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxDownArrow.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.Down_Arrow;
            this.PicBoxDownArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PicBoxDownArrow.Location = new System.Drawing.Point(452, 579);
            this.PicBoxDownArrow.Name = "PicBoxDownArrow";
            this.PicBoxDownArrow.Size = new System.Drawing.Size(50, 50);
            this.PicBoxDownArrow.TabIndex = 4;
            this.PicBoxDownArrow.TabStop = false;
            this.PicBoxDownArrow.Click += new System.EventHandler(this.PicBoxDownArrow_Click);
            // 
            // PlantZoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.Shovel_Closeup;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 641);
            this.Controls.Add(this.PicBoxDownArrow);
            this.Controls.Add(this.PicBoxBatteries);
            this.DoubleBuffered = true;
            this.Name = "PlantZoomForm";
            this.Text = "PlantZoomForm";
            this.Load += new System.EventHandler(this.PlantZoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxBatteries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxDownArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBoxBatteries;
        private System.Windows.Forms.PictureBox PicBoxDownArrow;
    }
}