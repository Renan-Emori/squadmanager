using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class UserEntity
    {
        public int Id { get; set; }

        public string? Type { get; set; }

        public string? ResetHash { get; set; }

        public string Password { get; set; }

        [ForeignKey("Person")]
        public int PersonID { get; set; }

        public PersonEntity Person { get; set; }
    }
}
