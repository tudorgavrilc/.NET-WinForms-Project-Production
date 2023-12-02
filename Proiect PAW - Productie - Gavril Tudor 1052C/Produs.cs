using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW___Productie___Gavril_Tudor_1052C
{
    internal class Produs: IComparable
    {
        private int id;
        private string denumire;
        private FisaConsum fisaConsum;
        private float pret;

        public Produs()
        {
            this.id = 0;
            this.denumire = "neatribuit";
            this.fisaConsum = null;
            this.pret = 0;
        }

        public Produs(int id, string denumire, FisaConsum fisaConsum, float pret)
        {
            this.id = id;
            this.denumire = denumire;
            this.fisaConsum = new FisaConsum(fisaConsum.DenumireProdus,fisaConsum.NrMateriale, 
                fisaConsum.NumeMateriale, fisaConsum.UnitateMasuraMateriale, fisaConsum.NrUMPerMaterial);
            this.pret = pret;
        }

        public int Id { get => id; set => id = value; }

        public string Denumire { get => denumire; set => denumire = value; }

        internal FisaConsum FisaConsum { get => fisaConsum; }

        public float Pret { get => pret; set => pret = value; }

        public override string ToString()
        {
            string result = "\nProdusul " +this.denumire +" cu ID-ul " + this.id + " are pretul " + this.pret + " si are fisa de consum: \n";
            result += this.fisaConsum.ToString();
            return result;
        }

        public int CompareTo(object obj)
        {
            Produs p = (Produs)obj;
            if (this.pret < p.pret) return -1;
            else if (this.pret == p.pret) return 0;
            else return 1;
        }

    }
}
