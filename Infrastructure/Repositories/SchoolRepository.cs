
using Application.Interface;
using Domain.Entities;

namespace Infrastructure.Repositories
{
    public class SchoolRepository : Repository<School>, ISchoolRepository
    {
        public SchoolRepository(Data.AppDbContext context) : base(context)
        {

        }
    }
}
