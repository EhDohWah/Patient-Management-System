using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using project_practice_3.MVC_Model;


namespace project_practice_3
{
    internal class DatabaseConnection: DbContext
    {
        // Defined the model 
        public DbSet<Patient> Patients { get; set; }

        public DbSet<FP_Data> Finger_Print_Data { get; set; }

        public DbSet<Address> Addresses { get; set; }

        public DbSet<Patient_OPD_Model> Patient_OPD {  get; set; }

        public DbSet<Patient_IPD_Model> Patient_IPD { get; set; }

        public DbSet<Patient_Transfer_Model> Patient_Transfer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Turtle\source\repos\project-practice-3\project-practice-3\patient-db.mdf;Integrated Security=True");
        }

    }
}
