using AzureFunctionSQLServer.Core;
using AzureFunctionSQLServer.Infrastructure;
using AzureFunctionSQLServer.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AzureFunctionSQLServer.Services
{
    public class WalletRepository : IWalletRepository
    {
        private readonly FuncDbContext _funcDbContext;

        public WalletRepository(FuncDbContext funcDbContext)
        {
            _funcDbContext = funcDbContext;
        }

        public async Task<IReadOnlyList<WalletDTO>> GetWalletsAsync()
        {
            return await _funcDbContext.Wallets.ToListAsync();
        }

        public async Task<WalletDTO> GetWalletsByIdAsync(int Id)
        {
            return await _funcDbContext.Wallets.FirstOrDefaultAsync(x => x.Id == Id);
        }
    }
}
