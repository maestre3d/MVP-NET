﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Axios.Domain;

namespace Axios.Services
{
    public interface IUserService
    {
        void ValidateModel(UserModel userModel);
    }
}
