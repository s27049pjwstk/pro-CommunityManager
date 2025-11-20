using Microsoft.EntityFrameworkCore;

namespace CommunityManager.Models;

public class SampleDb : DbContext {
    public DbSet<WorkOrder> WorkOrders => Set<WorkOrder>();

    public SampleDb() {}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlite("Data Source=database.db");
    }
}

public class WorkOrder {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Workdate { get; set; }
    public int Somevalue { get; set; }
}