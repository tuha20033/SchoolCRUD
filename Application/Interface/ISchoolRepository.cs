using Application.Repositories;

namespace Application.Interface
{
    public interface ISchoolRepository<T> : IRepository<T> where T : class
    {
      
    }
}
