using incapsulare.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incapsulare.service
{
    internal class MasinaService
    {

        private List<Masina> masini;



        public MasinaService()
        {

            masini = new List<Masina>();

            load();

        }

        public void load()
        {
            Masina m = new Masina("ford", "mustang", 2000, 12341, "wri123r", "noua", "intacta", "manuala");
            Masina n = new Masina("honda", "prelude", 1994, 134533, "sfOI32", "veche", "uzata", "manuala");
            Masina o = new Masina("pontiac", "trans am", 2001, 42124, "nIO94", "veche", "intacta", "automana");

            this.masini.Add(m);
            this.masini.Add(n);
            this.masini.Add(o);

        }


       
        public void showTabel(ListView tabel)
        {

            tabel.Clear();
            tabel.Columns.Add("Marca", 75, HorizontalAlignment.Left);
            tabel.Columns.Add("Model", 100, HorizontalAlignment.Left);
            tabel.Columns.Add("An", 75, HorizontalAlignment.Left);
            tabel.Columns.Add("Pret", 100, HorizontalAlignment.Left);
            tabel.Columns.Add("ID", 75, HorizontalAlignment.Left);
            tabel.Columns.Add("Vechime", 100, HorizontalAlignment.Left);
            tabel.Columns.Add("Stare", 75, HorizontalAlignment.Left);
            tabel.Columns.Add("Cutie de viteze", 100, HorizontalAlignment.Left);

            foreach (Masina masina in masini)
            {
                ListViewItem linie = new ListViewItem();
                linie.Text = masina.getMarca();
                linie.SubItems.Add(masina.getModel());
                linie.SubItems.Add(masina.getAn().ToString());
                linie.SubItems.Add(masina.getPret().ToString());
                linie.SubItems.Add(masina.getID().ToString());
                linie.SubItems.Add(masina.getVechime());
                linie.SubItems.Add(masina.getStare());
                linie.SubItems.Add(masina.getCutieViteze());

                tabel.Items.Add(linie);
            }
        }



    }
}
