using Microsoft.EntityFrameworkCore;
using Persistence.Entities;

namespace Persistence.Contexts;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<BookingEntity> Bookings { get; set; }
    public DbSet<BookingOwnerEntity> BookingOwners { get; set; }
    public DbSet<BookingAddressEntity> BookingAddresses { get; set; }
}