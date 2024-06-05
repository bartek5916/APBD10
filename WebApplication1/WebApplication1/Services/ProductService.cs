using WebApplication1.Contexts;
using WebApplication1.Models;
using WebApplication1.RequestModels;

namespace WebApplication1.Services;

public interface IProductService
{
    Task assignProduct(AssignProductRequestModel requestModel);
}

public class ProductService(DatabaseContext context) : IProductService
{
    public async Task assignProduct(AssignProductRequestModel requestModel)
    {
        var newProduct = new Products
        {
            ProductName = requestModel.productName,
            ProductWeight = requestModel.productWeight,
            ProductWidth = requestModel.productWidth,
            ProductHeight = requestModel.productHeight,
            ProductDepth = requestModel.productDepth,
            //Nieskonczone kategorie i ich walidacja
        };

        await context.Products.AddAsync(newProduct);
    }
}