using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Data
{
   public class AplicacionDbContext : DbContext
    {
        public AplicacionDbContext(DbContextOptions<AplicacionDbContext> options) : base(options)
        {

        }
    }
}
