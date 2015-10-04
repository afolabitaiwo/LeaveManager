using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Business.Services.Contexts.Validatiion;

namespace Business.Services.Contexts.Persistence.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<DepartmentEntity> DepartmentRepository { get; }
        IGenericRepository<EmployeeEntity> EmployeeRepository { get; }
        IGenericRepository<EmployeeLeaveEntity> EmployeeLeaveRepository { get; }
        IGenericRepository<EmployeeTypeEntity> EmployeeTypeRepository { get; }
        IGenericRepository<LeaveTypeEntity> LeaveTypeRepository { get; }
        IGenericRepository<LogEntity> LogRepository { get; }
        List<string> Commit();

    }
}