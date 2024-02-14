using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Behpouyan_
{
    internal class TankerContext:DbContext
    {
        public TankerContext(string name):base(name)
        {
            
        }

        public DbSet<Tanker> tankers { get; set; }
    }
}
