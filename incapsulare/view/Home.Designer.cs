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
            this.btnAddCar = new System.Windows.Forms.Button();
            this.lblCars = new System.Windows.Forms.Label();
            this.btnUpdateCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMasini
            // 
            this.lstMasini.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lstMasini.GridLines = true;
            this.lstMasini.Location = new System.Drawing.Point(82, 103);
            this.lstMasini.Name = "lstMasini";
            this.lstMasini.Size = new System.Drawing.Size(805, 315);
            this.lstMasini.TabIndex = 0;
            this.lstMasini.UseCompatibleStateImageBehavior = false;
            this.lstMasini.View = System.Windows.Forms.View.Details;
            this.lstMasini.SelectedIndexChanged += new System.EventHandler(this.lstMasini_SelectedIndexChanged);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddCar.Location = new System.Drawing.Point(82, 454);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(142, 47);
            this.btnAddCar.TabIndex = 1;
            this.btnAddCar.Text = "Add new car";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // lblCars
            // 
            this.lblCars.AutoSize = true;
            this.lblCars.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCars.Location = new System.Drawing.Point(420, 27);
            this.lblCars.Name = "lblCars";
            this.lblCars.Size = new System.Drawing.Size(85, 42);
            this.lblCars.TabIndex = 2;
            this.lblCars.Text = "Cars";
            // 
            // btnUpdateCar
            // 
            this.btnUpdateCar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateCar.Location = new System.Drawing.Point(695, 454);
            this.btnUpdateCar.Name = "btnUpdateCar";
            this.btnUpdateCar.Size = new System.Drawing.Size(192, 47);
            this.btnUpdateCar.TabIndex = 3;
            this.btnUpdateCar.Text = "Update existing car";
            this.btnUpdateCar.UseVisualStyleBackColor = true;
            this.btnUpdateCar.Click += new System.EventHandler(this.btnUpdateCar_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 527);
            this.Controls.Add(this.btnUpdateCar);
            this.Controls.Add(this.lblCars);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.lstMasini);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lstMasini;
        private Button btnAddCar;
        private Label lblCars;
        private Button btnUpdateCar;
    }
}