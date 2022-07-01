using System;
using MangoWeb.Models;
using MangoWeb.Services.IServices;
using MangoWeb.Web.Models.Dto;

namespace MangoWeb.Services
{
    public class ProductService : BaseService, IProductService
    {
        private readonly IHttpClientFactory _clientFactory;

        public ProductService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            this._clientFactory = clientFactory;
        }

        public async Task<T> CreateProductsAsync<T>(ProductDto productDto)
        {
            return await this.SendAsync<T>(new ApiRequest() {
                ApiType = SD.ApiType.POST,
                Data = productDto,
                Url = SD.ProductAPIBase + "api/products",
                AccessToken=""
            });
        }

        public async Task<T> DeleteProductsAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.DELETE,
                Url = SD.ProductAPIBase + "api/products/" + id,
                AccessToken = ""
            });
        }

        public async Task<T> GetAllProductsAsync<T>()
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ProductAPIBase + "api/products",
                AccessToken = ""
            });
        }

        public async Task<T> GetProductsByIdAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.GET,
                Url = SD.ProductAPIBase + "api/products/" + id,
                AccessToken = ""
            });
        }

        public async Task<T> UpdateProductsAsync<T>(ProductDto product)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.PUT,
                Data = product,
                Url = SD.ProductAPIBase + "api/products",
                AccessToken = ""
            });
        }
    }
}

