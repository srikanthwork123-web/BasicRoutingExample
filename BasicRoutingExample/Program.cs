//In dotnet core program exceution starts from program.cs.It does not conatin old .net framework like main method.
//whatever you written in this program.cs.exceution starts from first line onwords.
//Program.cs divided into 2 sections(1.DependencyInjectionContainer section .2.applicationpipeline section)
#region DependencyInjectionContainer
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#endregion 

#region applicationpipelinescetion
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
#endregion