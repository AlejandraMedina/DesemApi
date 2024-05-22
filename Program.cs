using DesemApi;
using Domino.EntidadesNegocio;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using Datos;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Datos.Repositorios;
using Dominio.InterfacesRepositorios;
using Aplicacion.Clases;
using Aplicacion.Interfaces;



var configurationBuilder = new ConfigurationBuilder();
configurationBuilder.AddJsonFile("appsettings.json", false, true);
var configuration = configurationBuilder.Build();

string strCon = configuration.GetConnectionString("MiConexion");
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
