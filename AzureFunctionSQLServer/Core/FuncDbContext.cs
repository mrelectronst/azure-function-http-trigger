using AzureFunctionSQLServer.Models;
using Microsoft.EntityFrameworkCore;

namespace AzureFunctionSQLServer.Core
{
    public class FuncDbContext: DbContext
    {
        public FuncDbContext(DbContextOptions<FuncDbContext> options) : base(options) { }
        
        public DbSet<WalletDTO> Wallets { get; set; }
    }
}
