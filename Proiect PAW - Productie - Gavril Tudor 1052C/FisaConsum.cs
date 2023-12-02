using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW___Productie___Gavril_Tudor_1052C
{
    internal class FisaConsum : ICloneable
    {
        private string denumireProdus;
        private int nrMateriale;
        private string[] numeMateriale;
        private string[] unitateMasuraMateriale;
        private int[] nrUMPerMaterial;

        public FisaConsum()
        {
            this.denumireProdus = "";
            this.nrMateriale = 0;
            this.numeMateriale = null;
            this.unitateMasuraMateriale = null;
            this.nrUMPerMaterial = null;
        }

        public FisaConsum(string denumireProdus, int nrMateriale, string[] numeMateriale, string[] unitateMasuraMateriale, int[] nrUMPerMaterial)
        {
            this.denumireProdus = denumireProdus;
            this.nrMateriale = nrMateriale;
            this.numeMateriale = new string[this.nrMateriale];
            this.unitateMasuraMateriale = new string[this.nrMateriale];
            this.nrUMPerMaterial = new int[this.nrMateriale];

            Array.Copy(numeMateriale, this.numeMateriale, this.nrMateriale);
            Array.Copy(unitateMasuraMateriale, this.unitateMasuraMateriale, this.nrMateriale);
            Array.Copy(nrUMPerMaterial, this.nrUMPerMaterial, this.nrMateriale);
        }

        public int NrMateriale { get => nrMateriale; set => nrMateriale = value; }

        public string[] NumeMateriale
        {
            get { return numeMateriale; }
            set 
            {
                string[] aux = new string[NrMateriale];
                Array.Copy(value, aux, NrMateriale);
                numeMateriale = aux;
            }
        }

        public string[] UnitateMasuraMateriale
        {
            get { return unitateMasuraMateriale; }
            set
            {
                string[] aux = new string[NrMateriale];
                Array.Copy(value, aux, NrMateriale);
                unitateMasuraMateriale = aux;
            }
        }

        public int[] NrUMPerMaterial
        {
            get { return nrUMPerMaterial; }
            set
            {
                int[] aux = new int[NrMateriale];
                Array.Copy(value, aux, NrMateriale);
                nrUMPerMaterial = aux;
            }
        }

        public string DenumireProdus { get => denumireProdus; set => denumireProdus = value; }

        public override string ToString()
        {
            string result = "\nFisa de consum pentru " +denumireProdus + "cu " + nrMateriale + " materiale:\n";

            for (int i = 0; i < nrMateriale; i++)
            {
                result += numeMateriale[i] + " - " + nrUMPerMaterial[i] + " " + unitateMasuraMateriale[i] + "\n";
            }

            return result;
        }

        public object Clone()
        {
            FisaConsum f = (FisaConsum)this.MemberwiseClone();
            string[] numeMaterialeClonate = (string[])numeMateriale.Clone();
            string[] unitateMasuraMaterialeClonat = (string[])unitateMasuraMateriale.Clone();
            int[] nrUMPerMaterialClonat = (int[])nrUMPerMaterial.Clone();
            f.denumireProdus = this.denumireProdus;
            f.numeMateriale = numeMaterialeClonate;
            f.unitateMasuraMateriale = unitateMasuraMaterialeClonat;
            f.nrUMPerMaterial = nrUMPerMaterialClonat;
            return f;

        }
    }
}
