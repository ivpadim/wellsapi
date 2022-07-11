
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/wells/{jobId}", (string jobId) =>
{
    var cacheKey = $"WELLS_COUNT_{jobId}";
    
    return Results.Ok(-1);
})
.Produces<int>(StatusCodes.Status200OK);

app.Run();