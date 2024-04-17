using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Zamestnanec
    {
        public Zamestnanec(int id, string jmeno, string primeni, DateTime datumNarozeni)
        {
            ID = id;
            Jmeno = jmeno;
            Primeni = primeni;
            DatumNarozeni = datumNarozeni;
        }

        public int ID { get; set; }
        public string Jmeno { get; set; }
        public string Primeni { get; set; }
        public DateTime DatumNarozeni { get; set; }

        public override string? ToString()
        {
            return $"{Jmeno} {Primeni} {DatumNarozeni.ToShortDateString()}";
        }
    }
}
