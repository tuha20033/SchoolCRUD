using Application.Interfaces;
using Domain.Entities;
using Domain.Repositories;
using System.Threading.Tasks;

namespace Application.Services;

public class SchoolService2 : ISchoolService
{
    private readonly IRepository<School> _schoolRepository;

    public SchoolService2(IRepository<School> schoolRepository)
    {
        _schoolRepository = schoolRepository;
    }

    public async Task AddSchool(School schoolDto)
    {
        await _schoolRepository.AddAsync(schoolDto);

    }
}
