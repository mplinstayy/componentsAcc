using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InventoryAcc.Models;

namespace InventoryAcc.Data
{
    public class InventoryAccContext : DbContext
    {
        public InventoryAccContext (DbContextOptions<InventoryAccContext> options)
            : base(options)
        {
        }

        public DbSet<ComponentViewModel> Component { get; set; } = default!;
    }
}
