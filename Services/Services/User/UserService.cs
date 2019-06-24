using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axios.Domain;
using Axios.Services.Common;

namespace Axios.Services
{
    public class UserService : IUserService, IUserRepository
    {
        private IUserRepository _userRepository;
        private IModelDataAnnotationCheck _modelDataAnnotationCheck;

        public UserService(IUserRepository userRepository, IModelDataAnnotationCheck modelDataAnnotationCheck)
        {
            _userRepository = userRepository;
            _modelDataAnnotationCheck = modelDataAnnotationCheck;
        }

        public void Add(UserModel user)
        {
            _userRepository.Add(user);
        }

        public void Delete(UserModel user)
        {
            _userRepository.Delete(user);
        }

        public IEnumerable<UserModel> GetAll()
        {
            return _userRepository.GetAll();
        }

        public UserModel GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void Update(UserModel user)
        {
            _userRepository.Update(user);
        }

        public void ValidateModel(UserModel userModel)
        {
            throw new NotImplementedException();
        }
    }
}
