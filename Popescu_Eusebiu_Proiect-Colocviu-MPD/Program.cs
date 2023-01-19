using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Popescu_Eusebiu_Proiect_Colocviu_MPD.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Popescu_Eusebiu_Proiect_Colocviu_MPDContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Popescu_Eusebiu_Proiect_Colocviu_MPDContext") ?? throw new InvalidOperationException("Connection string 'Popescu_Eusebiu_Proiect_Colocviu_MPDContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
