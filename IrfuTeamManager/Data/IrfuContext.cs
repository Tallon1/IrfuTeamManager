using IrfuTeamManager.Models.IRFU;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IrfuTeamManager.Data
{
    public class IrfuContext: DbContext
    {
        public IrfuContext() : base("DefaultConnection")
        { }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}