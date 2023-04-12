using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace incapsulare.view
{
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }

        private void Car_Load(object sender, EventArgs e)
        {

        }

        private void btnMasina_Click(object sender, EventArgs e)
        {
            string text = "";
            text += "Marca masinii este " + txtMarca.Text + "\n";
            text += "Modelul masinii este " + txtModel.Text + "\n";
            text += "Anul de fabricatie este " + txtAn.Text + "\n";
            text += "Pretul masinii este " + txtPret.Text + "\n";
            text += "Masina este " + txtVechime.Text + "\n";
            text += "Masina este " + txtStare.Text + "\n";
            text += "Cutia de viteze este " + txtViteze.Text + "\n";

            MessageBox.Show(text, "Descriere", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
