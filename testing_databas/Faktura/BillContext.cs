using DatabasesInformation;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using System;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Faktura
{
    // den klassen innehåler en instans DbContext som fungerar som en bro mellan koden och databasen genom det kommer jag kunna skicka 
    //querys till databasen. 
    public class BillContext : DbContext //using EF
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Topay> Topays { get; set; } //choose carefully the table name its can get u a lot of problems 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Faktura");
        }
    }
}
