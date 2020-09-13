

namespace WebShop.Data.Repository.Contract
{
    public interface IUnitOfWork
    {
        ICategoryRepo Category { get; }
        IProductRepo Product { get; }
        CORSRepo CORS { get; }
    }
}
