using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Entity;

namespace Repository
{
    public interface IPersonRepository
    {
        public int Add(PersonEntity entity);

        public void Update(PersonEntity entity);
    }
}
