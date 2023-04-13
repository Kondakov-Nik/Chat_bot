namespace Chat_Bot
{
    partial class help_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(help_form));
            this.HelpText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HelpText
            // 
            this.HelpText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpText.ForeColor = System.Drawing.Color.Red;
            this.HelpText.Location = new System.Drawing.Point(12, 9);
            this.HelpText.Name = "HelpText";
            this.HelpText.Size = new System.Drawing.Size(376, 232);
            this.HelpText.TabIndex = 2;
            this.HelpText.Text = resources.GetString("HelpText.Text");
            this.HelpText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // help_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.HelpText);
            this.Name = "help_form";
            this.Text = "help_form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label HelpText;
    }
}