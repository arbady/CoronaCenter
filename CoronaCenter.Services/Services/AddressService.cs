using CoronaCenter.Model.Forms;
using CoronaCenter.DataBase;
using CoronaCenter.Model.Entities;
using CoronaCenter.Services.Services.Bases;
using CoronaCenter.Model.Models;
using Microsoft.EntityFrameworkCore;
using CoronaCenter.Services.Mapper;

namespace CoronaCenter.Services.Services
{

    public class AddressService : BaseProvider<Address, AddressModel, AddressForm>
    {
        public AddressService(DataContext db) : base(db, new AddressMapper())
        {
        }

        protected override DbSet<Address> GetDbSet(DataContext dc)
        {
            return dc.Addresses;
        }
    }
}
