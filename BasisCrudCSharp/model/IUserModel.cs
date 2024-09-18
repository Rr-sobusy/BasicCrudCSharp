using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCrudCSharp.model
{
    public interface IUserModel
    {
        string Name { get; set; }
        int Age { get; set; }
        string Email { get; set; }
    }
}
