using FastEndpoints;
using FastEndpoints.Swagger;
using SiceiApi.CORE.Interfaces.Repositories;
using SiceiApi.CORE.Interfaces.Services;
using SiceiApi.CORE.Services;
using SiceiApi.DATA.Repository;

var bld = WebApplication.CreateBuilder();
bld.Services
    .AddFastEndpoints()
    .SwaggerDocument();

//bld.Services.SwaggerDocument(o =>
//{
//    o.DocumentSettings = s =>
//    {
//        s.Title = "Sicei API";
//        s.Version = "v1";
//    };
//});

bld.Services.AddScoped<IAlumnosRepository, AlumnosRepository>();
bld.Services.AddScoped<IAlumnosService, AlumnosService>();

bld.Services.AddScoped<IProfesorsRepository, ProfesorsRepository>();
bld.Services.AddScoped<IProfesoresService, ProfesorService>();

var app = bld.Build();


app.UseFastEndpoints()
    .UseSwaggerGen();


app.Run();