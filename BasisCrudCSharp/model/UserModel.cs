using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicCrudCSharp.model;


namespace BasicCrudCSharp.model
{
    public class UserModel : IUserModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
