using BLL.Services;
using Labo_CrowdFunding.api;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddScoped<IUserRepo, UserRepository>(c => new UserRepository(builder.Configuration.GetConnectionString("dev")));
//builder.Services.AddScoped<IProjectRepo, ProjectRepository>(c => new ProjectRepository(builder.Configuration.GetConnectionString("dev")));
//builder.Services.AddScoped<ICounterpartyRepo, CounterpartyRepository>(c => new CounterpartyRepository(builder.Configuration.GetConnectionString("dev")));
//builder.Services.AddScoped<IParticipationRepo, ParticipationRepository>(c => new ParticipationRepository(builder.Configuration.GetConnectionString("dev")));
string cs = builder.Configuration.GetConnectionString("dev");
builder.Services.AddScoped<UserService>();
builder.Services.AddAuthentication(option =>
{
    option.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    option.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(option =>
    {
        option.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
        };
    });
builder.Services.AddTransient<IJwtAuthenticationService, JwtAuthenticationService>();

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

app.Run();
