using System.Collections.Generic;

namespace Recrutify.DataAccess.Repositories.IRepository
{
    public interface ICourseRepository : IBaseRepository<Course>
    {
        public List<Course> GetAll();
    }
}
