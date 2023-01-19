using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Popescu_Eusebiu_Proiect_Colocviu_MPD.List;

namespace Popescu_Eusebiu_Proiect_Colocviu_MPD.Data
{
    public class Popescu_Eusebiu_Proiect_Colocviu_MPDContext : DbContext
    {
        public Popescu_Eusebiu_Proiect_Colocviu_MPDContext (DbContextOptions<Popescu_Eusebiu_Proiect_Colocviu_MPDContext> options)
            : base(options)
        {
        }

        public DbSet<Popescu_Eusebiu_Proiect_Colocviu_MPD.List.Client> Client { get; set; } = default!;
    }
}
