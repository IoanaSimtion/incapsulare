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
    public partial class Home : Form
    {

        private MasinaService masinaService;
        public Home()
        {
            InitializeComponent();

            this.masinaService = new MasinaService();

            this.masinaService.showTabel(lstMasini);
        }

       

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            Car frmnCar = new Car(this.masinaService);

            if(frmnCar.ShowDialog() == DialogResult.OK)
            {

                this.masinaService.showTabel(lstMasini);
            }
         }

        private void btnUpdateCar_Click(object sender, EventArgs e)
        {
            if (lstMasini.SelectedItems.Count > 0)
            {
                string id = lstMasini.SelectedItems[0].Text;

                UpdateCar update = new UpdateCar(masinaService, id);

                if (update.ShowDialog() == DialogResult.OK)
                {
                    masinaService.showTabel(lstMasini);
                }
            }
            else
            {
                MessageBox.Show("Select the car ID", "Update", MessageBoxButtons.OK);
            }
            
        }


        private void lstMasini_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("aici");

            

        }
    }
}
