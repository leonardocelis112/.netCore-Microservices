using System;
using MangoWeb.Models;
using MangoWeb.Web.Models.Dto;

namespace MangoWeb.Services.IServices
{
    public interface IBaseService : IDisposable
    {
        ResponseDto ResponseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}

