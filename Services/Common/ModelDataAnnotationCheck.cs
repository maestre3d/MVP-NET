using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Axios.Services.Common
{
    public class ModelDataAnnotationCheck
    {
        void ValidateModel<TDomainModel>(TDomainModel domainModel)
        {
            ICollection<ValidationResult> validationResultsList = new List<ValidationResult>();
            ValidationContext validationContext = new ValidationContext(domainModel, null, null);
            StringBuilder stringBuilder = new StringBuilder();

            if(!Validator.TryValidateObject(domainModel, validationContext, validationResultsList, validateAllProperties: true))
            {
                foreach(ValidationResult validationResult in validationResultsList)
                {
                    stringBuilder.Append(validationResult.ErrorMessage)
                                  .AppendLine();
                }
            }

            if(validationResultsList.Count > 0)
            {
                throw new ArgumentException(stringBuilder.ToString());
            }
        }
    }
}
