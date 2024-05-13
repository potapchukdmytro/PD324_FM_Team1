using FinancingManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinancingManager
{
    public class AppDbContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<CostEntity> Costs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("workstation id=PD324_Team1.mssql.somee.com;packet size=4096;user id=dbtest111_SQLLogin_1;pwd=ns5pnub5cb;data source=PD324_Team1.mssql.somee.com;persist security info=False;initial catalog=PD324_Team1;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
