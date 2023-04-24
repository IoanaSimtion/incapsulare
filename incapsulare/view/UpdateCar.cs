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

        private void txtAnUP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
