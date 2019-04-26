using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace JTTT
{   
    [Serializable]
    class JTTTRecipe
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public virtual JTTTAction Action { get; set; }

        [Required]
        public virtual JTTTQuestion Question { get; set; }

        public JTTTRecipe(JTTTAction action, JTTTQuestion question)
        {
            Action = action;
            Question = question; 
        }

        public void RunActions()
        {
            Action.InputParameters = Question.OutputParameters;
            Action.Action();
        }

        public override string ToString()
        {
            return string.Format("{0} {1}",Question.ToString(), Action.ToString());
        }

}
}
