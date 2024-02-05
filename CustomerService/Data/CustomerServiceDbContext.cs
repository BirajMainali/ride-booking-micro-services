﻿using CustomerService.Models;
using Microsoft.EntityFrameworkCore;

namespace CustomerService.Data;

public class CustomerServiceDbContext : DbContext
{
    public CustomerServiceDbContext(DbContextOptions<CustomerServiceDbContext> options)
        : base(options)
    {
    }

    public DbSet<RiderRequest> RiderRequests { get; set; }
}