using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW___Productie___Gavril_Tudor_1052C
{
    internal class LotFabricatie: IComparable, ICloneable, ICalcule
    {
        private int idLotFabricatie;
        private int nrTipuriProduse;
        private int[] idProduse;
        private int[] nrExemplareProduse;
        private int nrProduseTotale;

        public LotFabricatie()
        {
            this.idLotFabricatie = 0;
            this.nrTipuriProduse = 0;
            this.idProduse = null;
            this.nrExemplareProduse = null;
            this.nrProduseTotale = 0; 
    }

        public LotFabricatie(int idLotFabricatie, int nrTipuriProduse, int[] idProduse, int[] nrExemplareProduse)
        {
            this.idLotFabricatie = idLotFabricatie;
            this.nrTipuriProduse = nrTipuriProduse;
            this.idProduse = new int[this.nrTipuriProduse];
            this.nrExemplareProduse = new int[this.nrTipuriProduse];

            Array.Copy(idProduse, this.idProduse, this.nrTipuriProduse);
            Array.Copy(nrExemplareProduse, this.nrExemplareProduse, this.nrTipuriProduse);

        }

        public int NrTipuriProduse { get => nrTipuriProduse; set => nrTipuriProduse = value; }

        public int[] IdProduse
        {
            get { return idProduse; }
            set
            {
                int[] aux = new int[NrTipuriProduse];
                Array.Copy(value, aux, NrTipuriProduse);
                idProduse = aux;
            }
        }

        public int[] NrExemplareProduse
        {
            get { return nrExemplareProduse; }
            set
            {
                int[] aux = new int[NrTipuriProduse];
                Array.Copy(value, aux, NrTipuriProduse);
                nrExemplareProduse = aux;
            }
        }

        public int NrProduseTotale { get => nrProduseTotale; set => nrProduseTotale = value; }

        public int IdLotFabricatie { get => idLotFabricatie; set => idLotFabricatie = value; }

        public int calculeazaNrProduseTotale()
        {
            this.nrProduseTotale = 0;
            for (int i = 0; i < this.nrTipuriProduse; i++)
            {
                this.nrProduseTotale += this.nrExemplareProduse[i];
            }
            return this.nrProduseTotale;
        }

        public int CompareTo(object obj)
        {
            LotFabricatie lot = (LotFabricatie)obj;
            if (this.nrProduseTotale < lot.nrProduseTotale) return -1;
            else if (this.nrProduseTotale == lot.nrProduseTotale) return 0;
            else return 1;
        }

        public override string ToString()
        {
            string result = "\nLotul de fabricatie cu ID-ul " + this.idLotFabricatie + ":\n";
            for(int i=0; i<this.nrTipuriProduse; i++)
            {
                result += "ID: " + this.idProduse[i] + "  Cantitate: " + this.nrExemplareProduse[i] + '\n';
            }
            result += "Nr total de produse in acest lot: " + this.nrProduseTotale + '\n';
            return result;
        }

        public object Clone()
        {
            LotFabricatie l = (LotFabricatie)this.MemberwiseClone();
            int[] idProduseClonate = (int[])idProduse.Clone();
            int[] nrExemplareProduseClonate = (int[])nrExemplareProduse.Clone();
            l.idProduse = idProduseClonate;
            l.nrExemplareProduse = nrExemplareProduseClonate;
            return l;

        }
       

    }
}
