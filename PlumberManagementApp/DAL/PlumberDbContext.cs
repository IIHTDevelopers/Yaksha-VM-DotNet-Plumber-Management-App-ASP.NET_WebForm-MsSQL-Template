using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using PlumberManagementApp.Model;

namespace PlumberManagementApp.DAL
{
    public class PlumberDbContext : DbContext
    {
        public DbSet<Model.PlumberModel> PlumberModels { get; set; }

        public PlumberDbContext() : base("ConnStr")
        {
        }
    }
}