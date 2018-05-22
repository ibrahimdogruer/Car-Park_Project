using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    public class Araba
    {
        public int ArabaNo { get; set; }
        public string Renk { get; set; }
        public Araba(int arabaNo, string renk)
        {
            this.Renk = renk;
            this.ArabaNo = arabaNo;
        }
        public override string ToString()
        {
            return "No: " + ArabaNo + "  Renk: " + Renk + Environment.NewLine;
        }
    }
}
