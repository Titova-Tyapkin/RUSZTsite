using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RUSZTsite.RUSTContex
{
    public class RustShopContext : DbContext
    {



        public RustShopContext(DbContextOptions <RustShopContext> options)
               : base(options)
        {
        }


    }
}