using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RUSZTsite.tabe
{
    public class User
    {
        public int UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FIO { get; set; }
        public DateTime Birth { get; set; }
        public int Balance { get; set; }



       // public List<Zakaz> Order { get; set; }
       // Zakaz = new List<Zakaz  m> 

    }
}


