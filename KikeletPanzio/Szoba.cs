using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KikeletPanzio
{
    public class Szoba
    {
         int szobaSzam;
         int ferohely;
         int ar;

        public Szoba(int szobaSzam, int ferohely, int ar)
        {
            this.szobaSzam = szobaSzam;
            this.ferohely = ferohely;
            this.ar = ar;
        }

        public int SzobaSzam { get => szobaSzam; set => szobaSzam = value; }
        public int Ferohely { get => ferohely; set => ferohely = value; }
        public int Ar { get => ar; set => ar = value; }

        public override string ToString()
        {
            return $"Szobaszám: {szobaSzam}, Férőhely: {ferohely}, Éjszakánkénti ár: {ar}";
        }
    }
}
