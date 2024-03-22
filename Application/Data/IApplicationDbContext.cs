using System.Collections.Generic;
using Domain.Customers;
using Microsoft.EntityFrameworkCore;

namespace Application.Data;

public interface IApplicationDbContext
{

    DbSet<Customer> Customers { get; set; }

    //DbSet<Order> Orders { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);

}