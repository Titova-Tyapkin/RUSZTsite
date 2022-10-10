using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RUSZTsite.tabe
{
    public class Sotrudnik
    {
        public int SotrudnikId { get; set; }
        public int SkladID { get; set; }
        public string FIO { get; set; }
        public string Foto { get; set; }
        public string Doljnost { get; set; }
    }
}