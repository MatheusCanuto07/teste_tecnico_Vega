using productSupplierControl.Infraestrutura;
using productSupplierControl.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IMaterialRepository, MaterialRepository>();
builder.Services.AddTransient<ISupplierRepository, SupplierRepository>();

builder.Services.AddCors(options =>
{
   options.AddPolicy(name: "MinhaPolitica",
           policy =>
           {
               policy.WithOrigins("http://localhost:8080", "http://localhost:5502", "https://localhost:7090", "http://127.0.0.1:5500" , "http://localhost:5501", "http://127.0.0.1:5501", "http://localhost:5173", "http://localhost:5173/registerMaterial", "http://localhost:5173/registerSupplier")
               .AllowAnyMethod()
               .AllowAnyHeader()
           ;
           }
       );
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("MinhaPolitica");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
