using Microsoft.EntityFrameworkCore;
using myfinance_web_dotnet.Domain;

namespace myfinance_web_dotnet.Infrastructure
{
    public class MyFinanceDBContext : DbContext
    {
        public DbSet<PlanoContas> PlanoContas { get; set; }
        public DbSet<TransacoesFinanceiras> TransacoesFinanceiras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=LOCALHOST\SQLEXPRESS; Database = myfinanceweb;Trusted_Connection=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}