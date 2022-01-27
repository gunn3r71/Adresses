using System.ComponentModel;

namespace ConsultaCep.API.Models
{
    public class AddressModel
    {
        public string Cep { get; set; }
        
        public string Street { get; set; }

        public string Neighborhood { get; set; }

        public string City { get; set; }

        public string State { get; set; }
    }
}