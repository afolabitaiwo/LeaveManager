using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Business.Services.Contexts.Validatiion;
using System.Configuration.Provider;
using System.Linq.Expressions;
using Business.Services.Managers.DataProviderManager.Concrete;

namespace Business.Services.Managers.DataProviderManager.Interface
{
    public interface ILeaveCalendarDataProcessor
    {

        void Dispose();
        LeaveCalendarDataEFProcessor ILeaveCalendarDataProcessor();

        List<string> Remove(EmployeeEntity employee, bool notPurging = true);
        List<string> Remove(EmployeeLeaveEntity employeeLeave, bool notPurging = true);
        List<string> Remove(EmployeeTypeEntity employeeType, bool notPurging = true);
        List<string> Remove(DepartmentEntity department, bool notPurging = true);
        List<string> Remove(LeaveTypeEntity leaveType, bool notPurging = true);
        List<string> Add(EmployeeEntity employee);
        List<string> Add(EmployeeLeaveEntity employeeLeave);
        List<string> Add(EmployeeTypeEntity employeeType);
        List<string> Add(DepartmentEntity department);
        List<string> Add(LeaveTypeEntity leaveType);
        List<string> Add(LogEntity log);

        List<string> Edit(EmployeeEntity employee);
        List<string> Edit(EmployeeLeaveEntity employeeLeave);
        List<string> Edit(EmployeeTypeEntity employeeType);
        List<string> Edit(DepartmentEntity department);
        List<string> Edit(LeaveTypeEntity leaveType);

        IQueryable<DepartmentEntity> Departments(Expression<Func<DepartmentEntity, bool>> predicate);

        IQueryable<LeaveTypeEntity> LeaveTypes(Expression<Func<LeaveTypeEntity, bool>> predicate);

        IQueryable<EmployeeLeaveEntity> EmployeeLeaves(Expression<Func<EmployeeLeaveEntity, bool>> predicate);

        List<EmployeeEntity> GetAll();
    }
}