using incapsulare.model;
using incapsulare.view;

namespace incapsulare
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //// To customize application configuration such as set high DPI settings or default font,
            //// see https://aka.ms/applicationconfiguration.
            //ApplicationConfiguration.Initialize();
            //Application.Run(new Car());
            Application.Run(new Home());



            //crearea de obiecte



            //Masina p = m;

            //p.setMarca("test");
            ////MessageBox.Show(p.getMarca());
            ////MessageBox.Show(p.descriere());


            //List<Masina> masinas = new List<Masina>();


            //masinas.Add(m);

            //masinas


            //Masina m = new Masina("wri123r,ford,mustang,2000,12341,noua,intacta,manuala");

            //MessageBox.Show(m.toSave());




        }
    }
}