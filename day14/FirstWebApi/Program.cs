using DOL;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/api/products",()=>{
    List<Product> prods=DataAccessLayer.DAL.GetAllProducts();
    return Results.Ok(prods);
});

app.MapGet("/api/products/{pid}",(int pid)=>{
    return Results.Ok(DataAccessLayer.DAL.GetById(pid));
});

app.Run();
