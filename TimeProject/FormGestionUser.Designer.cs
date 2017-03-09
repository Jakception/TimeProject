namespace TimeProject
{
    partial class FormGestionUser
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
            this.lstBoxUser = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBoxUser
            // 
            this.lstBoxUser.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstBoxUser.FormattingEnabled = true;
            this.lstBoxUser.Location = new System.Drawing.Point(26, 44);
            this.lstBoxUser.Name = "lstBoxUser";
            this.lstBoxUser.Size = new System.Drawing.Size(250, 485);
            this.lstBoxUser.TabIndex = 0;
            // 
            // FormGestionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(826, 601);
            this.Controls.Add(this.lstBoxUser);
            this.Name = "FormGestionUser";
            this.Text = "FormGestionUser";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBoxUser;
    }
}