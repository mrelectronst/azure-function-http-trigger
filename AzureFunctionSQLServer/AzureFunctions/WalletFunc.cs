using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using AzureFunctionSQLServer.Infrastructure;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using AzureFunctionSQLServer.Models;

namespace AzureFunctionSQLServer
{
    public class WalletFunc
    {
        private readonly IWalletRepository _walletRepository;

        public WalletFunc(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }


        [FunctionName("GetAllWallets")]
        public async Task<IReadOnlyList<WalletDTO>> GetAllWallets(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "Wallet")] HttpRequest req,
            ILogger log)
        {
            var wallets = await _walletRepository.GetWalletsAsync();

            return wallets;
        }

        [FunctionName("GetWalletById")]
        public async Task<IActionResult> GetWalletById(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = "Wallet/{Id}")] HttpRequest req,
            ILogger log, int Id)
        {
            var wallet = await _walletRepository.GetWalletsByIdAsync(Id);

            return new OkObjectResult(wallet);
        }
    }
}
