
using Application.Interfaces;
using Domain.Repositories;

namespace Application.Services;

public class WrapperService
{
    private readonly ISchoolService school1;
    private readonly SchoolService2 school2;

    private readonly IRepository<C> _schoolRepository;
    private readonly IRepository<D> _schoolRepository;
    public WrapperService(ISchoolService school1, SchoolService2 school2)
    {
        this.school1 = school1;
        this.school2 = school2;
    }
}

class SharedCache
{
    public List<string> data { get; set; } = new List<string>();
}