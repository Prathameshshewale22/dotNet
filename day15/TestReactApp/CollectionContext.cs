using Microsoft.EntityFrameWorkCore;

using BOL;

namespace DAL;

public class CollectionContext:DbContext{
    public DbSet<Product> products {get;set;}

    protected override void OnConfiguring(DbcontextOptionsBuilder optionsBuilder){
        string connstring=@"server=localhost;port=3306;user=root; password=root@123;database=test";
        optionsBuilder.UseMySQL(connstring);
    }

    protected override void onModelCreating(ModelBuilder modelBuilder){
        base.onModelCreating(modelBuilder);
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