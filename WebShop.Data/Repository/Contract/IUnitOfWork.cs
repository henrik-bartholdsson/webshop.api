namespace WebShop.Data.Repository.Contract
{
    public interface IUnitOfWork
    {
        ICategoryRepo Category { get; }
        IProductRepo Product { get; }
        IOrderRepo Order { get; }
        CORSRepo CORS { get; }
    }
}
