using eSimpleBlob.BusinessLogic.AppBL;
using eSimpleBlob.BusinessLogic.Interfaces;
using eSimpleBlob.Handlers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICustomer, CustomerBL>();
builder.Services.AddScoped<eSimpleBlob.BusinessLogic.Interfaces.ISession, SessionBL>();
builder.Services.RegisterRequestHandlers();


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

