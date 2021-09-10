using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BAITH2.Models
{
    public partial class LapTrinhQuanLyDBcontext : DbContext
    {
        public LapTrinhQuanLyDBcontext()
            : base("name=LapTrinhQuanLyDBcontext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
