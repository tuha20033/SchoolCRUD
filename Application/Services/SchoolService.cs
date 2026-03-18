using Application.Interfaces;
using Domain.Entities;
using Domain.Repositories;
using System.Threading.Tasks;

namespace Application.Services;

public class SchoolService : ISchoolService
{
    private readonly IRepository<School> _schoolRepository;
    private readonly IRepository<A> _schoolRepository;
    private readonly IRepository<B> _schoolRepository;
    private readonly IRepository<C> _schoolRepository;
    private readonly IRepository<D> _schoolRepository;
    private readonly ISchoolService _school2;

    public SchoolService(IRepository<School> schoolRepository, SchoolService2 school2)
    {
        _schoolRepository = schoolRepository;
        _school2 = school2;
    }

    public async Task AddSchool(School schoolDto)
    {
        await _schoolRepository.AddAsync(schoolDto);

    }
}
