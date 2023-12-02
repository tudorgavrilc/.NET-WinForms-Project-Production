using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW___Productie___Gavril_Tudor_1052C
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] numeMateriale = new string[] { "Tesatura", "Nasturi" };
            string[] unitateMasuraMateriale = new string[] {"mp", "buc" };
            int[] nrUMPerMaterial = new int[] { 5, 8 };
            FisaConsum fisa1 = new FisaConsum("Camasa Maneca Lunga",2, numeMateriale, unitateMasuraMateriale, nrUMPerMaterial);
            //Console.WriteLine(fisa1);

            Produs camasaML = new Produs(23, "Camasa Maneca Lunga", fisa1, 30);
            Produs camasaMS = new Produs(24, "Camasa Maneca Scurta", fisa1, 35);
            //Console.WriteLine(camasa);

            int[] idProduse = new int[] { camasaML.Id, camasaMS.Id };
            int[] nrExemplareProduse = new int[] { 500, 600 };
            LotFabricatie lot1 = new LotFabricatie(1, 2, idProduse, nrExemplareProduse);
            lot1.calculeazaNrProduseTotale();
            Console.WriteLine(lot1);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());

        }
    }
}
