namespace incapsulare.view
{
    partial class Car
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
            this.btnMasina = new System.Windows.Forms.Button();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblAn = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.f = new System.Windows.Forms.Label();
            this.lblStare = new System.Windows.Forms.Label();
            this.lblViteze = new System.Windows.Forms.Label();
            this.lblMasina = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtStare = new System.Windows.Forms.TextBox();
            this.txtViteze = new System.Windows.Forms.TextBox();
            this.txtVechime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMasina
            // 
            this.btnMasina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMasina.Location = new System.Drawing.Point(647, 361);
            this.btnMasina.Name = "btnMasina";
            this.btnMasina.Size = new System.Drawing.Size(141, 77);
            this.btnMasina.TabIndex = 0;
            this.btnMasina.Text = "Apasati pentru a afisa proprietatile masinii";
            this.btnMasina.UseVisualStyleBackColor = true;
            this.btnMasina.Click += new System.EventHandler(this.btnMasina_Click);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.Location = new System.Drawing.Point(15, 95);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(70, 28);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblModel.Location = new System.Drawing.Point(15, 142);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(73, 28);
            this.lblModel.TabIndex = 2;
            this.lblModel.Text = "Model:";
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAn.Location = new System.Drawing.Point(15, 184);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(147, 28);
            this.lblAn.TabIndex = 3;
            this.lblAn.Text = "Anul fabricatiei:";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPret.Location = new System.Drawing.Point(15, 225);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(51, 28);
            this.lblPret.TabIndex = 4;
            this.lblPret.Text = "Pret:";
            // 
            // f
            // 
            this.f.AutoSize = true;
            this.f.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.f.Location = new System.Drawing.Point(15, 268);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(89, 28);
            this.f.TabIndex = 5;
            this.f.Text = "Vechime:";
            // 
            // lblStare
            // 
            this.lblStare.AutoSize = true;
            this.lblStare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStare.Location = new System.Drawing.Point(15, 311);
            this.lblStare.Name = "lblStare";
            this.lblStare.Size = new System.Drawing.Size(60, 28);
            this.lblStare.TabIndex = 6;
            this.lblStare.Text = "Stare:";
            // 
            // lblViteze
            // 
            this.lblViteze.AutoSize = true;
            this.lblViteze.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblViteze.Location = new System.Drawing.Point(15, 357);
            this.lblViteze.Name = "lblViteze";
            this.lblViteze.Size = new System.Drawing.Size(144, 28);
            this.lblViteze.TabIndex = 7;
            this.lblViteze.Text = "Cutie de viteze:";
            // 
            // lblMasina
            // 
            this.lblMasina.AutoSize = true;
            this.lblMasina.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMasina.Location = new System.Drawing.Point(312, 25);
            this.lblMasina.Name = "lblMasina";
            this.lblMasina.Size = new System.Drawing.Size(105, 38);
            this.lblMasina.TabIndex = 8;
            this.lblMasina.Text = "Masina";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(91, 99);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(125, 27);
            this.txtMarca.TabIndex = 9;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(91, 146);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(125, 27);
            this.txtModel.TabIndex = 10;
            // 
            // txtAn
            // 
            this.txtAn.Location = new System.Drawing.Point(168, 188);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(125, 27);
            this.txtAn.TabIndex = 11;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(72, 229);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(125, 27);
            this.txtPret.TabIndex = 12;
            // 
            // txtStare
            // 
            this.txtStare.Location = new System.Drawing.Point(81, 315);
            this.txtStare.Name = "txtStare";
            this.txtStare.PlaceholderText = "uzata/intacta";
            this.txtStare.Size = new System.Drawing.Size(94, 27);
            this.txtStare.TabIndex = 13;
            // 
            // txtViteze
            // 
            this.txtViteze.Location = new System.Drawing.Point(165, 361);
            this.txtViteze.Name = "txtViteze";
            this.txtViteze.PlaceholderText = "manuala/automata";
            this.txtViteze.Size = new System.Drawing.Size(141, 27);
            this.txtViteze.TabIndex = 14;
            // 
            // txtVechime
            // 
            this.txtVechime.Location = new System.Drawing.Point(110, 272);
            this.txtVechime.Name = "txtVechime";
            this.txtVechime.PlaceholderText = "noua/veche";
            this.txtVechime.Size = new System.Drawing.Size(83, 27);
            this.txtVechime.TabIndex = 15;
            // 
            // Car
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtVechime);
            this.Controls.Add(this.txtViteze);
            this.Controls.Add(this.txtStare);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMasina);
            this.Controls.Add(this.lblViteze);
            this.Controls.Add(this.lblStare);
            this.Controls.Add(this.f);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblAn);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnMasina);
            this.Name = "Car";
            this.Text = "Car";
            this.Load += new System.EventHandler(this.Car_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMasina;
        private Label lblMarca;
        private Label lblModel;
        private Label lblAn;
        private Label lblPret;
        private Label f;
        private Label lblStare;
        private Label lblViteze;
        private Label lblMasina;
        private TextBox txtMarca;
        private TextBox txtModel;
        private TextBox txtAn;
        private TextBox txtPret;
        private TextBox txtStare;
        private TextBox txtViteze;
        private TextBox txtVechime;
    }
}