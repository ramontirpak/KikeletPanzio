using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KikeletPanzio
{
    public class Ugyfel
    {
        string id;
        string nev;
        DateTime szulDatum;
        string email;
        bool vip;

        public Ugyfel(string nev, DateTime szulDatum, string email, bool vip)
        {
            this.id = IdGeneral(nev);
            this.nev = nev;
            this.szulDatum = szulDatum;
            this.email = email;
            this.vip = vip;
        }

        public string Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public DateTime SzulDatum { get => szulDatum; set => szulDatum = value; }
        public string Email { get => email; set => email = value; }
        public bool Vip { get => vip; set => vip = value; }

        public string IdGeneral(string nev)
        {
            return $"{nev}_{DateTime.Now}";
        }

        public override string ToString()
        {
            return $"{id} {nev} {szulDatum} {email} {vip}";
        }
    }
}
