using Domain.Entities;
using Domain.Repositories;

namespace Infrastructure.Repositories
{
    public class SchoolRepository : Repository<School>, ISchoolRepository
    {
        public SchoolRepository(Data.AppDbContext context) : base(context)
        {

        }
    }
}

