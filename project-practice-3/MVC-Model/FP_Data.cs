using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace project_practice_3.MVC_Model
{
    internal class FP_Data
    {
        [Key] // Specifies that this is the primary key 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        public string PID { get; set; }

        public string FingerName { get; set; }

        [MaxLength(5000)]
        public string FingerPrintID { get; set; }

        public string Comment { get; set; }


        [ForeignKey("PID")]
        public Patient Patient { get; set; } // Establishes a relationship with the Patient entity

    }
}
