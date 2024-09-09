using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_practice_3.MVC_Model
{
    internal class Patient_IPD_Model
    {
        [Key] // Specifies that this is the primary key
        [Column(TypeName = "VARCHAR(10)")]
        public string AN { get; set; } // Admission Number (Primary Key)

        [ForeignKey("Patient")] // Foreign key that references the 'Patients' table
        [Column(TypeName = "VARCHAR(10)")]
        public string PID { get; set; }

        [Column(TypeName = "VARCHAR(10)")]
        public string SiteCode { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime? AdmitDate { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime? DischargeDate { get; set; }

        [Column(TypeName = "VARCHAR(20)")]
        public string Status { get; set; }

        // Navigation property for the related Patient
        public virtual Patient Patient { get; set; }
    }
}
