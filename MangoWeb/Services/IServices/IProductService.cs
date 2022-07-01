using System;
using MangoWeb.Web.Models.Dto;

namespace MangoWeb.Services.IServices
{
    public interface IProductService : IBaseService
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetProductsByIdAsync<T>(int id);
        Task<T> CreateProductsAsync<T>(ProductDto product);
        Task<T> UpdateProductsAsync<T>(ProductDto product);
        Task<T> DeleteProductsAsync<T>(int id);
    }
}

