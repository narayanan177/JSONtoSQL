using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLDBforJsonDataApp
{
    public class PolicyContext : DbContext
    {
        public PolicyContext() : base("MydbConn")
        {

        }
        public DbSet<Policy> Policy { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Agency> Agency { get; set; }
        public DbSet<Binder> binder { get; set; }
        public DbSet<TotalAnnualPremium> totalannualpremium { get; set; }
        public DbSet<TotalTransactionPremium> totaltransactionpremium { get; set; }
        public Page[] pages { get; set; }
        public Section[] sections { get; set; }
        public Endorsement[] endorsements { get; set; }
    }
}
