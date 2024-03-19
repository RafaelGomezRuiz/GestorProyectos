var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options=>
{
    options.AddPolicy("PoliticaRandom",app=> 
    {
        app.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

builder.Services.AddSqlServer<TareaContext>(builder.Configuration.GetConnectionString("CnDbPManager"));
builder.Services.AddScoped<ITareaService,Contexto>();
//builder.Services.AddScoped<IUsuarioService,UsuarioService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c=>{
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Mi API");
        c.RoutePrefix = string.Empty; // Para que Swagger esté disponible en la raíz
        // despues de la segunda linea me abre con swagger automatico
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors("PoliticaRandom");
// app.UseCors(c=> c.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());



app.MapControllers();

app.Run();
