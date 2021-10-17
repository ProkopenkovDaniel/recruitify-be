using System.Collections.Generic;
using Recrutify.DataAccess.Models;

namespace Recrutify.DataAccess.Repositories.IRepository
{
    public interface IBaseRepository<T>
        where T : IDataModel
    {
        public List<T> GetAll();
    }
}
