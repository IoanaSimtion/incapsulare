using incapsulare.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incapsulare.service
{
    public class MasinaService
    {

        private List<Masina> masini;
        private string path = Application.StartupPath + @"\data\masini.txt";

        public Masina getMasina(String id)
        {
            foreach (Masina masina in masini)
            {
                if (masina.getID().Equals(id))
                {
                    return masina;
                }
            }

            return null;
            
        }

        public MasinaService()
        {

            masini = new List<Masina>();

            load();

        }

        public void load()
        {

                  

            StreamReader streamReader = new StreamReader(path);
            string line = "";
            while ((line =streamReader.ReadLine())!= null){

                Masina masina = new Masina(line);

                masini.Add(masina);

            }

            streamReader.Close();

        }

        public void addCar(Masina car)
        {
            this.masini.Add(car);
        }

       
        public void showTabel(ListView tabel)
        {

            tabel.Clear();
            tabel.Columns.Add("ID", 75, HorizontalAlignment.Left);
            tabel.Columns.Add("Marca", 75, HorizontalAlignment.Left);
            tabel.Columns.Add("Model", 100, HorizontalAlignment.Left);
            tabel.Columns.Add("An", 75, HorizontalAlignment.Left);
            tabel.Columns.Add("Pret", 100, HorizontalAlignment.Left);           
            tabel.Columns.Add("Vechime", 100, HorizontalAlignment.Left);
            tabel.Columns.Add("Stare", 75, HorizontalAlignment.Left);
            tabel.Columns.Add("Cutie de viteze", 100, HorizontalAlignment.Left);

            foreach (Masina masina in masini)
            {
                ListViewItem linie = new ListViewItem();
                linie.Text = masina.getID();
                linie.SubItems.Add(masina.getMarca().ToString());
                linie.SubItems.Add(masina.getModel());
                linie.SubItems.Add(masina.getAn().ToString());
                linie.SubItems.Add(masina.getPret().ToString());
                linie.SubItems.Add(masina.getVechime());
                linie.SubItems.Add(masina.getStare());
                linie.SubItems.Add(masina.getCutieViteze());

                tabel.Items.Add(linie);
            }
        }


        //todo:functie ce primeste ca parametru id unei masini si returneaza pozitia pe care se afla


        public int getPoz(String id)
        {
            int i = 0;
            foreach(Masina masina in masini)
            {
                if (masina.getID().Equals(id))
                {
                    return i;
                }
                i++;
            }
            return -1;
        }



        public void deleteCar(String id)
        {
            int index=getPoz(id);

            this.masini.RemoveAt(index);                       
        }


        public string toSave()
        {

            string text = "";
            int i = 0;
            for (i = 0; i < masini.Count - 1; i++)
            {

                text += masini[i].toSave() + "\n";

            }
            text += masini[i].toSave();
            return text;
        }

        public void save()
        {
            StreamWriter writer = new StreamWriter(path);


            writer.WriteLine(toSave());

            writer.Close();
        }
       
    }
}
