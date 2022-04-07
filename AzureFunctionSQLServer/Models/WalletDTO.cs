using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureFunctionSQLServer.Models
{
    public class WalletDTO
    {
        [Key]
        public int Id { get; set; }

        public decimal? Amount { get; set; }

        public string? Direction { get; set; }

        public int? Account { get; set; }
    }
}
