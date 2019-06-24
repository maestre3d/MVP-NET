using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axios.Domain;

namespace Axios.Services
{
    public interface IUserRepository
    {
        void Add(UserModel user);
        void Update(UserModel user);
        void Delete(UserModel user);
        IEnumerable<UserModel> GetAll();
        UserModel GetById(int id);
    }
}
