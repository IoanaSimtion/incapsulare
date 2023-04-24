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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
