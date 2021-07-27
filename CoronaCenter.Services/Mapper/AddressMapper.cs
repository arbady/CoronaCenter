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
    public class AddressMapper : BaseMapper, IMapper<Address, AddressModel, AddressForm>
    {
        public AddressModel MapEntityToModel(Address entity)
        {
            if (CheckIfNull(entity)) return null;
            
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
            if (CheckIfNull(form)) return null;

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
            if (CheckIfNull(model)) return null;
            return new Address {
                Id = model.Id,
                Province = model.Province,
                City = model.City,
                ZipCode = model.ZipCode,
                Street = model.Street,
                Number = model.Number
            };
        }

        public AddressForm MapModelToForm(AddressModel entity)
        {
            if (CheckIfNull(entity)) return null;
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
