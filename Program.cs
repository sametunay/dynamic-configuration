using CustomCs.Configuration.Extensions;
using CustomCs.Configuration.Sources;

var builder = WebApplication.CreateBuilder(args);


builder.Configuration.AddDynamicConfiguration(opt =>
{
    opt.DataSource = new TestSource();
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();