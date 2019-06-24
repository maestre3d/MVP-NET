using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axios.Domain
{
    public class UserModel : IUserModel
    {
        [Key]
        public string Id { get; set; }

        [RegularExpression("([a-zA-Z0-9]+)", ErrorMessage = "Solo caracteres alfanuméricos.")]
        public string Name { get; set; }

        [RegularExpression("([a-zA-Z0-9]+)", ErrorMessage = "Solo caracteres alfanuméricos.")]
        public string Surname { get; set; }
    }
}
