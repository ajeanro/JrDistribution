using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
    public class DistributionContext : DbContext
    {
        public DistributionContext(DbContextOptions<DistributionContext> options)
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<CustomerOrder> CustomerOrders { get; set; }

        public DbSet<OrderedProduct> Orderedproducts { get; set; }

        public DbSet<Cart> Carts { get; set; }

    }
}
