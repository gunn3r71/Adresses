using Adresses.API.Models;
using Refit;
using System;
using System.Threading.Tasks;

namespace ConsultaCep.API.Services
{
    public class AdressesService
    {
        private readonly IAdressesService _adressesService;

        public AdressesService()
        {
            var apiUrl = "https://brasilapi.com.br/api/";
            _adressesService = RestService.For<IAdressesService>(apiUrl);
        }

        public async Task<ResponseModel> GetAddressByZipCode(string zipcode)
        {
            try
            {
                var result = await _adressesService.GetAddressByZipCodeAsync(zipcode);
                return new()
                {
                    Success = true,
                    Message = "Address found",
                    Data = result
                };
            }
            catch (ApiException)
            {
                return new()
                {
                    Success = false,
                    Message = "Address not found",
                    Data = null
                };
            }
            catch (Exception)
            {
                return new()
                {
                    Success = false,
                    Message = "An unexpected error occurred",
                    Data = null
                };
            }
        }
    }
}