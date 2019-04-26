using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTTT
{
    class JTTTQuestion
    {

        public int Id { get; set; }
        public virtual void Question() { }
        public virtual object[] OutputParameters { get; protected set; }
    }
}
