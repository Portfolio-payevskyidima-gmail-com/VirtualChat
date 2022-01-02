using Microsoft.EntityFrameworkCore;
using VirtualChat.Repository;
using VirtualChat.Repository.Repository;
using VirtualChat.Services.Services.UserStatusAdminService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<VirtalChatDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("myconn")));

#region Dependency injections
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddTransient<IUserStatusAdminService, UserStatusAdminService>();
#endregion

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

app.Run();
