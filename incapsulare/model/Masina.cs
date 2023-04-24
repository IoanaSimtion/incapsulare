using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incapsulare.model
{
    public class Masina
    {
        //todo :5 proprietati
        private string marca;
        private string model;
        private int an;
        private double pret;
        private string id;
        private string vechime;
        private string stare;
        private string cutieViteze;


        public Masina()
        {

        }

        public Masina(string id, string marca,string model, int an, double pret, string vechime, string stare, string cutieViteze)
        {
            this.marca = marca;
            this.model = model;
            this.an = an;
            this.pret = pret;
            this.id = id;
            this.vechime = vechime;
            this.stare = stare;
            this.cutieViteze = cutieViteze;
        }


        public Masina(string proprietati)
        {
            string[] propr = proprietati.Split(",");

            this.id = propr[0];
            this.marca = propr[1];
            this.model = propr[2];
            this.an = Int32.Parse(propr[3]);
            this.pret = Double.Parse(propr[4]);
            this.vechime = propr[5];
            this.stare = propr[6];
            this.cutieViteze = propr[7];

        }

        public string descriere()
        {
            string text = "";

            text += "Marca este " + marca + "\n";
            text += "Modelul este " + model + "\n";
            text += "Anul este " + an + "\n";
            text += "Pretul este " + pret + "\n";
            text += "ID-ul este " + id + "\n";
            text += "Masina este " + vechime + "\n";
            text += "Masina este " + stare + "\n";
            text += "Cutia de viteze este " + cutieViteze + "\n";
            return text;
        }

        //get set


        public void setMarca(String marca)
        {
            this.marca = marca;
        }

        public String getMarca()
        {

            return this.marca;
        }

        public void setModel(String model)
        {
            this.model = model;
        }

        public String getModel()
        {
            return this.model;
        }

        public void setAn(int an)
        {
            this.an = an;
        }

        public int getAn()
        {
            return this.an;
        }

        public void setPret(double pret)
        {
            this.pret = pret;
        }

        public double getPret()
        {
            return this.pret;
        }

        public void setID(String id)
        {
            this.id = id;
        }

        public String getID()
        {
            return this.id;
        }

        public void setVechime(String vechime)
        {
            this.vechime = vechime;
        }

        public String getVechime()
        {
            return this.vechime;
        }

        public void setStare(String stare)
        {
            this.stare = stare;
        }

        public String getStare()
        {
            return this.stare;
        }

        public void setCutieViteze(String cutieViteze)
        {
            this.cutieViteze = cutieViteze;
        }

        public String getCutieViteze()
        {
            return this.cutieViteze;
        }

        public string toSave()
        {
            string carData = "";

            carData += this.id + ",";
            carData += this.marca + ",";
            carData += this.model + ",";
            carData += this.an + ",";
            carData += this.pret + ",";
            carData += this.vechime + ",";
            carData += this.stare + ",";
            carData += this.cutieViteze;
           

            return carData;
        }

    }
}
