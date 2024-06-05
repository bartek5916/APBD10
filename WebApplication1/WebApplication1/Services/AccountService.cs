using Microsoft.EntityFrameworkCore;
using WebApplication1.Contexts;
using WebApplication1.Models;
using WebApplication1.ResponseModels;

namespace WebApplication1.Services;

public interface IAccountService
{
    Task<GetAccountResponseModel> GetAccountIdAsync(int id);
}

public class AccountService(DatabaseContext context) : IAccountService
{
    public async Task<GetAccountResponseModel> GetAccountIdAsync(int id)
    {
        var result = await context.Accounts
            .Where(a => a.AccountId == id)
            .Select(a => new GetAccountResponseModel
            {
                firstName = a.AccountFirstName,
                lastName = a.AccountLastName,
                email = a.AccountEmail,
                phone = a.AccountPhone,
                role = a.Role.RoleName,
                cart = a.ShoppingCartsEnumerable.Select(shoppingCart => new ShoppingCartDetails
                {
                    ProductId = shoppingCart.ProductId,
                    ProductName = shoppingCart.Products.ProductName,
                    amount = shoppingCart.ShoppingCartAmount
                }).ToList()
            }).FirstOrDefaultAsync();

        if (result is null)
        {
            //Pracownik nie istnieje
            throw new NotFoundException($"Account with id: {id} does not exist.");
        }

        return result;
    }
}
