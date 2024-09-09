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

    internal class Address
    {
        [Key] // Specifies that this is the primary key 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Column(TypeName = "VARCHAR(20)")]
        public string AddressCode { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string SectionName_EN { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        public string VillageCode { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string VillageName_EN { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string VillageName_MM { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string VillageName_KAREN { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string VillageGPSLat { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string VillageGPSLong { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string SubdistrictCode { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string SubdistrictName_EN { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string DistrictCode { get; set; }

        [Column(TypeName = "VARCHAR(50)")] 
        public string DistrictName_EN { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string ProvinceCode { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string ProvinceName_EN { get; set; }

        [Column(TypeName = "VARCHAR(20)")]
        public string RegionCode { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string RegionName_EN { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        public string CountryCode { get; set; }

        [Column(TypeName = "VARCHAR(50)")] 
        public string CountryName_EN { get; set; }

    }
}
