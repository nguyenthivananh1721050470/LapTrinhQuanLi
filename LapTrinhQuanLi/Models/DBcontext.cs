using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LapTrinhQuanLi.Models
{
    public partial class DBcontext : DbContext
    {
        public DBcontext()
            : base("name=DBcontext")
        {
        }

        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<HeDaotao> HeDaotaos { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
