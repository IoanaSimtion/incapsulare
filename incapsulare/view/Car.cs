using incapsulare.model;
using incapsulare.service;
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

        private MasinaService masinaService;
        public Car()
        {
            InitializeComponent();
        }


        public Car(MasinaService masinaService)
        {
            InitializeComponent();
            this.masinaService = masinaService;
        }
        private void Car_Load(object sender, EventArgs e)
        {

        }


        private void btnMasina_Click(object sender, EventArgs e)
        {
            if (validateForm() == true)
            {
                Masina car = new Masina();

                car.setMarca(txtMarca.Text);
                car.setModel(txtModel.Text);
                car.setAn(Int32.Parse(txtAn.Text));
                car.setPret(Double.Parse(txtPret.Text));
                car.setID(txtID.Text);
                car.setVechime(txtVechime.Text);
                car.setStare(txtStare.Text);
                car.setCutieViteze(txtViteze.Text);

                this.masinaService.addCar(car);

                this.DialogResult = DialogResult.OK;
            }

        }


        private bool validateForm()
        {
            String text = "";

            if (txtMarca.Text.Equals(""))
            {
                text += "Introduceti marca masinii\n";
            }
            if (txtModel.Text.Equals(""))
            {
                text += "Introdecti modelul masinii\n";
            }
            if (txtAn.Text.Equals(""))
            {
                text += "Introduceti anul de fabricatie al masinii\n";
            }
            if (txtPret.Text.Equals(""))
            {
                text += "Introduceti pretul masinii\n";
            }
            if (txtVechime.Text.Equals(""))
            {
                text += "Introduceti vechimea masinii\n";
            }
            if (txtStare.Text.Equals(""))
            {
                text += "Introduceti starea masinii\n";
            }
            if (txtViteze.Text.Equals(""))
            {
                text += "Introduceti tipul cutiei de viteze\n";
            }
            if (txtID.Text.Equals(""))
            {
                text += "Introduceti ID-ul masinii\n";
            }

            if (text.Length > 0)
            {
                MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
