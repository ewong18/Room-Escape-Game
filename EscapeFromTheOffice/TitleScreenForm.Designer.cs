namespace EscapeFromTheOffice
{
    partial class TitleScreenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TitleScreenForm));
            this.RTF_TitleText = new System.Windows.Forms.RichTextBox();
            this.PicBoxStartButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxStartButton)).BeginInit();
            this.SuspendLayout();
            // 
            // RTF_TitleText
            // 
            this.RTF_TitleText.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RTF_TitleText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTF_TitleText.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RTF_TitleText.DetectUrls = false;
            this.RTF_TitleText.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTF_TitleText.ForeColor = System.Drawing.Color.Lime;
            this.RTF_TitleText.Location = new System.Drawing.Point(311, 135);
            this.RTF_TitleText.Name = "RTF_TitleText";
            this.RTF_TitleText.ReadOnly = true;
            this.RTF_TitleText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RTF_TitleText.ShortcutsEnabled = false;
            this.RTF_TitleText.Size = new System.Drawing.Size(350, 247);
            this.RTF_TitleText.TabIndex = 0;
            this.RTF_TitleText.TabStop = false;
            this.RTF_TitleText.Text = resources.GetString("RTF_TitleText.Text");
            // 
            // PicBoxStartButton
            // 
            this.PicBoxStartButton.BackColor = System.Drawing.Color.Transparent;
            this.PicBoxStartButton.Location = new System.Drawing.Point(388, 543);
            this.PicBoxStartButton.Name = "PicBoxStartButton";
            this.PicBoxStartButton.Size = new System.Drawing.Size(219, 61);
            this.PicBoxStartButton.TabIndex = 1;
            this.PicBoxStartButton.TabStop = false;
            this.PicBoxStartButton.Click += new System.EventHandler(this.PicBoxStartButton_Click);
            // 
            // TitleScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EscapeFromTheOffice.Properties.Resources.Title_Computer;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(944, 641);
            this.Controls.Add(this.PicBoxStartButton);
            this.Controls.Add(this.RTF_TitleText);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "TitleScreenForm";
            this.Text = "Escape to the Weekend";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxStartButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox RTF_TitleText;
        private System.Windows.Forms.PictureBox PicBoxStartButton;
    }
}