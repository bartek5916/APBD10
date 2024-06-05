using Microsoft.EntityFrameworkCore;
using WebApplication1;
using WebApplication1.Contexts;
using WebApplication1.RequestModels;
using WebApplication1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DatabaseContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("api/accounts/{accountId:int}", async (int accountId, IAccountService service) =>
{
    try
    {
        return Results.Ok(await service.GetAccountIdAsync(accountId));
    }
    catch (NotFoundException e )
    {
        return Results.NotFound(e.Message);
    }
});

app.MapPost("api/products/", async (AssignProductRequestModel requestModel, IProductService productService) =>
{
    try
    {
        await productService.assignProduct(requestModel);
        return Results.NoContent();
    }
    catch (Exception e)
    {
        return Results.NoContent();
    }
});

app.Run();
