using CoronaCenter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoronaCenter.Services.Services.Bases
{
    public interface ISecurity 
    {
        public UserPublic Check(string mail, string password);
    }
}
