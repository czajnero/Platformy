using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace JTTT
{
    class JTTTDBContext : DbContext
    {
        public JTTTDBContext() 
        {
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<JTTTAction> JTTTActions { get; set; }
        public DbSet<JTTTRecipe> JTTTRecipes { get; set; }


    }
}
