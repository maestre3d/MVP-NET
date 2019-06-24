using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axios.Domain;
using Axios.Services;
using Axios.Services.Common;

namespace Axios.Services.Tests
{
    class UserServiceFixture
    {
        private IUserService _userServices;
        private UserModel _userModel;

        public UserServiceFixture()
        {
            _userModel = new UserModel();
            _userServices = new UserService(null, null);
        }

        public UserModel UserModel
        {
            get { return (UserModel)_userModel; }
            set { _userModel = value; }
        }

        public UserService UserService {
            get { return (UserService)_userServices; }
            set { _userServices = value; }
        }
    }
}
