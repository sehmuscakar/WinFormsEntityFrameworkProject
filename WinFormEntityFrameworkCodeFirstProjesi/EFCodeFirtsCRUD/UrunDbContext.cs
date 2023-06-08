using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirtsCRUD
{
    public class UrunDbContext:DbContext//entityframework sayesinde 
    {
        public DbSet<Product> Products { get; set; }    


    }
}
