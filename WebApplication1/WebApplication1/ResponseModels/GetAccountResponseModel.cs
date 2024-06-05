using WebApplication1.Models;

namespace WebApplication1.ResponseModels;

public class GetAccountResponseModel
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public string phone { get; set; }
    public string role { get; set; }
    public List<ShoppingCartDetails> cart { get; set; }
}

public class ShoppingCartDetails
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double amount { get; set; }
}