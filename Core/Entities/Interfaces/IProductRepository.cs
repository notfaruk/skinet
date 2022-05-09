namespace Core.Entities.Interfaces
{
    public interface IProductRepository
    {
       Task<Product>GetProductByIdAsync(int id);
       Task<IReadOnlyList<Product>>GetProductsAsync();
       Task<IReadOnlyList<ProductBrand>>GetProductBrandsAsync();

       Task<IReadOnlyList<ProductType>>GetProducTypesAsync();
        Task<object> GetProductTypesAsync();
    }
}