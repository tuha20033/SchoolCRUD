using Domain.Entities;

namespace Application.Interfaces;

public interface ISchoolService
{
    Task AddSchool(School schoolDto);
}
