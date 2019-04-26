using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JTTT
{
    [Serializable]
    class JTTTAction
    {
      public int Id { get; set; }
      public virtual void Action() { }
      public virtual object[] InputParameters { get; set; }
        

    }
}
