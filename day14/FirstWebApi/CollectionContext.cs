using Microsoft.EntityFrameworkCore;

using BOL;

namespace DAL;

public class CollectionContext:DbContext{
    public DbSet<Product> Products {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        string connstring=@"server=localhost;port=3306;user=root; password=root@123;database=test";
        optionsBuilder.UseMySQL(connstring);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>(entity=>{
            entity.HasKey(e=>e.Pid);
            entity.Property(e=>e.Pname);
            entity.Property(e=>e.Description);
            entity.Property(e=>e.Price);
            entity.Property(e=>e.Quntity);
        });
        modelBuilder.Entity<Product>().ToTable("product");
    }
}