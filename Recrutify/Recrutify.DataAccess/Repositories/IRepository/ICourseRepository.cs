using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recrutify.DataAccess.Repositories.IRepository
{
    public interface ICourseRepository : IBaseRepository<Course>
    {
        public List<Course> GetAll();
    }
}
