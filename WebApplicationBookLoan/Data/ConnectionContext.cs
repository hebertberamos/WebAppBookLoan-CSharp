using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationBookLoan.Models;

namespace WebApplicationBookLoan.Data
{
    public class ConnectionContext : DbContext
    {
        public ConnectionContext (DbContextOptions<ConnectionContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationBookLoan.Models.Loan> Loan { get; set; } = default!;
    }
}
