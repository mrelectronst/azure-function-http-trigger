using AzureFunctionSQLServer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AzureFunctionSQLServer.Infrastructure
{
    public interface IWalletRepository
    {
        Task<IReadOnlyList<WalletDTO>> GetWalletsAsync();

        Task<WalletDTO> GetWalletsByIdAsync(int Id);
    }
}
