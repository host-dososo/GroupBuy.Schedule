using GroupBuy.Schedule.Models.Entites;
using GroupBuy.Schedule.Services;
using GroupBuy.Schedule.Services.Swagger;
using Hangfire;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Microsoft.VisualBasic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// 設置跨網域連線
var allowedCorsOrigins = AppSettingService.Get<string[]>("AllowedCorsOrigins");
builder.Services.AddCors(options =>
{
    options.AddPolicy("NormalCorsPolicy", builder =>
    {
        builder.WithOrigins(allowedCorsOrigins).AllowAnyMethod().AllowAnyHeader();
    });
    options.AddPolicy("AllowAll", builder =>
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader());
});


builder.Services.AddAuthorization();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => {
    c.EnableAnnotations(); // 啟用標註功能
    c.DocumentFilter<CustomDocumentFilter>();
    
});

builder.Services.AddScoped<ScheduleService>();
builder.Services.AddScoped<JobService>();
//builder.Services.AddScoped<MyHttpService>();

builder.Services.AddDbContext<GroupBuyEntities>(opt => builder.Configuration.GetConnectionString("DefaultConnection"));
// 設置 entity framework 產生器
var serviceProvider = builder.Services.BuildServiceProvider();
EFService.SetEntities(serviceProvider.GetService<GroupBuyEntities>());

// 設定 Hangfire 服務
builder.Services.AddHangfire(config =>
{
    config.UseSqlServerStorage(builder.Configuration.GetConnectionString("DefaultConnection")).WithJobExpirationTimeout(TimeSpan.FromDays(30));
});

// 在服務中加入 Hangfire 伺服器
builder.Services.AddHangfireServer(c => {
    c.WorkerCount = 40;
});
var app = builder.Build();

EnvService.Initialize(app.Services.GetRequiredService<IWebHostEnvironment>());
app.UseDefaultFiles();
app.UseStaticFiles();
app.UseCors("NormalCorsPolicy");
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();
// 啟用 Hangfire 儀表板
app.UseHangfireDashboard();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.UseRouting();

app.MapFallbackToFile("/index.html");

app.Run();
