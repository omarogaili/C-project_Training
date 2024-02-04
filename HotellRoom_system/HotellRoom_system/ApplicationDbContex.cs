using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HotellRoom_system
{
    public class ApplicationDbContex : DbContext
    {
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Cost> Costs { get; set; }
        public DbSet<RoomCost> roomCosts { get; set; }
        public DbSet<RoomView> RoomViews { get; set; }
        // connection string for the local server.  
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HotellSystem"); //can be changed if u have another server. 
        }
    }
}
