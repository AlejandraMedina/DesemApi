using Aplicacion.Clases;
using Aplicacion.Interfaces;
using Datos.Repositorios;
using DesemApi;
using Dominio.InterfacesRepositorios;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;



var configurationBuilder = new ConfigurationBuilder();
configurationBuilder.AddJsonFile("appsettings.json", false, true);
var configuration = configurationBuilder.Build();

#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
string strCon = configuration.GetConnectionString("MiConexion");
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DesemContext>(options => options.UseSqlServer(strCon));

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options => options.IncludeXmlComments("DesemApi.xml"));


////////////////// JWT ///////////////////////////////////
var claveSecreta = "ZZZWRpw6fDo28gZW0gY29tcHV0YWRvcmE="; //PUEDE SER OTRA CLAVE, SI ES FUERTE

builder.Services.AddAuthentication(aut =>
{
    aut.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    aut.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(aut =>
{
    aut.RequireHttpsMetadata = false;
    aut.SaveToken = true;
    aut.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(claveSecreta)),
        ValidateIssuer = false,
        ValidateAudience = false
    };
});
//////////////////// FIN JWT ////////////////////////


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepositorioUsuarios, RepositorioUsuarios>();

builder.Services.AddScoped<ILoginUsuario, LoginUsuario>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}




app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});


app.Run();
