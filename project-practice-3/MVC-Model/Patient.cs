using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_practice_3.MVC_Model
{
    internal class Patient
    {
        [Key] // Specifies that this is the primary key 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string PID { get; set; }
        public string FullName { get; set; }    
    }
}
