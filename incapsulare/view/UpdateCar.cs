using incapsulare.model;
using incapsulare.service;
using incapsulare.view;
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
    public partial class UpdateCar : Form
    {
        private MasinaService masinaService;

        private Masina forUpdateMasina;

        public UpdateCar(MasinaService masinaService, String id)
        {
            InitializeComponent();
            this.BringToFront();
            this.masinaService = masinaService;
            this.forUpdateMasina = masinaService.getMasina(id);
            carData();

        }


        public void carData()
        {
            txtIdUp.Text = this.forUpdateMasina.getID();
            txtMarcaUp.Text = this.forUpdateMasina.getMarca();
            txtModelUp.Text = this.forUpdateMasina.getModel();
            txtAnUp.Text = this.forUpdateMasina.getAn().ToString();
            txtPretUp.Text = this.forUpdateMasina.getPret().ToString();
            txtVechimeUp.Text = this.forUpdateMasina.getVechime();
            txtVitezeUp.Text = this.forUpdateMasina.getCutieViteze();
            txtStareUp.Text = this.forUpdateMasina.getStare();

        
        }

        

        private void UpdateCar_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validateForm() == true)
            {

                this.forUpdateMasina.setAn(Int32.Parse(txtAnUp.Text));
                this.forUpdateMasina.setMarca(txtMarcaUp.Text);
                this.forUpdateMasina.setStare(txtStareUp.Text);
                this.forUpdateMasina.setCutieViteze(txtVitezeUp.Text);
                this.forUpdateMasina.setVechime(txtVechimeUp.Text);
                this.forUpdateMasina.setID(txtIdUp.Text);
                this.forUpdateMasina.setPret(Double.Parse(txtPretUp.Text));
                this.forUpdateMasina.setModel(txtModelUp.Text);

                this.DialogResult = DialogResult.OK;
            }
        }

        private bool validateForm()
        {
            String text = "";

            if (txtMarcaUp.Text.Equals(""))
            {
                text += "Introduceti marca masinii\n";
            }
            if (txtModelUp.Text.Equals(""))
            {
                text += "Introdecti modelul masinii\n";
            }
            if (txtAnUp.Text.Equals(""))
            {
                text += "Introduceti anul de fabricatie al masinii\n";
            }
            if (txtPretUp.Text.Equals(""))
            {
                text += "Introduceti pretul masinii\n";
            }
            if (txtVechimeUp.Text.Equals(""))
            {
                text += "Introduceti vechimea masinii\n";
            }
            if (txtStareUp.Text.Equals(""))
            {
                text += "Introduceti starea masinii\n";
            }
            if (txtVitezeUp.Text.Equals(""))
            {
                text += "Introduceti tipul cutiei de viteze\n";
            }
            if (txtIdUp.Text.Equals(""))
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
        private void txtAnUP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.masinaService.deleteCar(forUpdateMasina.getID());

            this.DialogResult = DialogResult.OK;
        }
    }
}
