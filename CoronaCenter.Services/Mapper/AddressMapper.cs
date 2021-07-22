using CoronaCenter.Model.Entities;
using CoronaCenter.Model.Forms;
using CoronaCenter.Model.Models;
using CoronaCenter.Services.Services.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Services.Mapper
{
    public class AddressMapper : IMapper<Address, AddressModel, AddressForm>
    {
        public AddressModel MapEntityToModel(Address entity)
        {
            return new AddressModel
            {
                Id = entity.Id,
                Province = entity.Province,
                City = entity.City,
                ZipCode = entity.ZipCode,
                Street = entity.Street,
                Number = entity.Number
            };
        }

        public Address MapFormToEntity(AddressForm form)
        {
            return new Address
            {
                Id = form.Id,
                Province = form.Province,
                City = form.City,
                ZipCode = form.ZipCode,
                Street = form.Street,
                Number = form.Number
            };
        }

        public Address MapModelToEntity(AddressModel model)
        {
            return model;
        }

        public AddressForm MapModelToForm(Address entity)
        {
            return new AddressForm
            {
                Id = entity.Id,
                Province = entity.Province,
                City = entity.City,
                ZipCode = entity.ZipCode,
                Street = entity.Street,
                Number = entity.Number
            };
        }
    }
}
