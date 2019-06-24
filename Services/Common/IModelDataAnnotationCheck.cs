using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios.Services.Common
{
    interface IModelDataAnnotationCheck
    {
        void ValidateModel<TDomainModel>(TDomainModel domainModel);
    }
}
