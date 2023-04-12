namespace incapsulare.view
{
    partial class Home
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
            this.lstMasini = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lstMasini
            // 
            this.lstMasini.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstMasini.GridLines = true;
            this.lstMasini.Location = new System.Drawing.Point(25, 44);
            this.lstMasini.Name = "lstMasini";
            this.lstMasini.Size = new System.Drawing.Size(754, 316);
            this.lstMasini.TabIndex = 0;
            this.lstMasini.UseCompatibleStateImageBehavior = false;
            this.lstMasini.View = System.Windows.Forms.View.Details;
            this.lstMasini.SelectedIndexChanged += new System.EventHandler(this.lstMasini_SelectedIndexChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstMasini);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lstMasini;
    }
}