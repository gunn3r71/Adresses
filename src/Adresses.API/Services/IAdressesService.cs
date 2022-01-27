using System.Collections.Generic;
using System.Threading.Tasks;
using ConsultaCep.API.Models;
using Microsoft.AspNetCore.Mvc;
using Refit;

namespace ConsultaCep.API.Services
{
    public interface IAdressesService
    {
        [Get("/cep/v2/{cep}")]
        Task<AddressModel> GetAddressByZipCodeAsync([FromRoute] string cep);
    }
}