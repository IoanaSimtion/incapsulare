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

        private void lstMasini_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
