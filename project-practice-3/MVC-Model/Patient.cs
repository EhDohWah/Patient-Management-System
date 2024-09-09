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

        [Column(TypeName = "VARCHAR(10)")]
        public string PID { get; set; }

        [ForeignKey("Address")] // Specifies the relationship to the Address table
        [Column(TypeName = "VARCHAR(20)")]
        public string AddressCode { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime? AdmissionDate { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string FullName { get; set; }

        [Column(TypeName = "VARCHAR(10)")]
        public string MotherPID { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        public string MotherName { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        public string FatherName { get; set; }

        [Column(TypeName = "VARCHAR(255)")]
        public string SpouseName { get; set; }

        [Column(TypeName = "TINYINT")]
        public byte? Gender { get; set; } // TINYINT in SQL maps to byte in C#

        [Column(TypeName = "VARCHAR(50)")]
        public string PhoneNumber { get; set; }

        [Column(TypeName = "DATE")]
        public DateTime? DOB { get; set; }

        [Column(TypeName = "VARCHAR(MAX)")]
        public string Note { get; set; }

        [Column(TypeName = "VARCHAR(MAX)")]
        public string AddressOther { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string SiteCode { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string BloodGroup { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string G6PD { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string Allergy { get; set; }
                
        [Column(TypeName = "VARCHAR(100)")]
        public string CreatedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime? CreatedDate { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string ModifiedBy { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime? ModifiedDate { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime? LastModified { get; set; }

        [Column(TypeName = "DATETIME")]
        public DateTime? LastSync { get; set; }

        // Navigation property for related Address
        public virtual Address Address { get; set; }
    }
}
