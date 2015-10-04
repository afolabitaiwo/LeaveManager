using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Business.Services.Contexts.Validatiion;
using Business.Services.Contexts.Persistence;
using Business.Portable.Enums;
using System.Linq.Expressions;
using Business.Services.Managers.DataProviderManager.Interface;

namespace Business.Services.Managers.DataProviderManager.Concrete
{


    public class LeaveCalendarDataEFProcessor : ILeaveCalendarDataProcessor
    {
        protected MyLeaveCalenderContext DbContext = null;
        private bool disposed;

        public LeaveCalendarDataEFProcessor ILeaveCalendarDataProcessor() 
        {
            var instance = new LeaveCalendarDataEFProcessor();
            instance.DbContext = new MyLeaveCalenderContext();
            return instance;
        }

        public void Dispose() // Implement IDisposable
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // called via myClass.Dispose().
                    // OK to use any private object references
                    if (DbContext != null)
                        DbContext.Dispose();
                }

                disposed = true;
            }
        }

        public  List<string> Remove(DepartmentEntity dept, bool notPurging = true)
        {
            DepartmentEntity department = DbContext.DepartmentRepository.GetAll().FirstOrDefault(u => u.DepartmentId == dept.DepartmentId);

            var errors = new List<string>();
            if (department != null)
            {
                if (notPurging)
                {
                    department.RecordState.RecordStateType = RecordStateType.Inactive;
                    department.RecordState.ModfiedByUserId = department.RecordState.ModfiedByUserId;
                    DbContext.Entry(department).State = EntityState.Modified;
                }
                else
                    DbContext.Entry(department).State = EntityState.Deleted;
            }
            else
            {
                errors.Add("Custom : No such department matches the id");
            }
            return errors;

        }

        public  List<string> Remove(EmployeeEntity emp, bool notPurging = true)
        {
            EmployeeEntity employee = DbContext.EmployeeRepository.GetAll().FirstOrDefault(u => u.EmployeeId == emp.EmployeeId);

            var errors = new List<string>();
            if (employee != null)
            {
                if (notPurging)
                {
                    employee.RecordState.RecordStateType = RecordStateType.Inactive;
                    employee.RecordState.ModfiedByUserId = employee.RecordState.ModfiedByUserId;
                    DbContext.Entry(employee).State = EntityState.Modified;
                }
                else
                    DbContext.Entry(employee).State = EntityState.Deleted;
            }
            else
            {
                errors.Add("Custom : No such employee mateches the id");
            }
            return errors;
        }

        public  List<string> Remove(LeaveTypeEntity leave_Type, bool notPurging = true)
        {
            LeaveTypeEntity leaveType = DbContext.LeaveTypeRepository.GetAll().FirstOrDefault(u => u.LeaveTypeId == leave_Type.LeaveTypeId);

            var errors = new List<string>();
            if (leaveType != null)
            {
                if (notPurging)
                {
                    leaveType.RecordState.RecordStateType = RecordStateType.Inactive;
                    leaveType.RecordState.ModfiedByUserId = leaveType.RecordState.ModfiedByUserId;
                    DbContext.Entry(leaveType).State = EntityState.Modified;
                }
                else
                    DbContext.Entry(leaveType).State = EntityState.Deleted;

            }
            else
            {
                errors.Add("Custom : No such leave type mateches the id");
            }

            return errors;

        }

        public  List<string> Remove(EmployeeTypeEntity employee_Type, bool notPurging = true)
        {
            EmployeeTypeEntity employeeType = DbContext.EmployeeTypeRepository.GetAll().FirstOrDefault(u => u.EmployeeTypeId == employee_Type.EmployeeTypeId);

            var errors = new List<string>();
            if (employeeType != null)
            {
                if (notPurging)
                {
                    employeeType.RecordState.RecordStateType = RecordStateType.Inactive;
                    employeeType.RecordState.ModfiedByUserId = employeeType.RecordState.ModfiedByUserId;
                    DbContext.Entry(employeeType).State = EntityState.Modified;
                }
                else
                    DbContext.Entry(employeeType).State = EntityState.Deleted;

            }
            else
            {
                errors.Add("Custom : No such employment type mateches the id");
            }

            return errors;

        }

        public  List<string> Remove(EmployeeLeaveEntity employee_leave, bool notPurging = true)
        {
            EmployeeLeaveEntity employeeLeave = DbContext.EmployeeLeaveRepository.GetAll().FirstOrDefault(u => u.EmployeeLeaveId == employee_leave.EmployeeLeaveId);

            var errors = new List<string>();
            if (employeeLeave != null)
            {
                if (notPurging)
                {
                    employeeLeave.RecordState.RecordStateType = RecordStateType.Inactive;
                    employeeLeave.RecordState.ModfiedByUserId = employeeLeave.RecordState.ModfiedByUserId;
                    DbContext.Entry(employeeLeave).State = EntityState.Modified;
                }
                else
                    DbContext.Entry(employeeLeave).State = EntityState.Deleted;
            }
            else
            {
                errors.Add("Custom : No such leave instance matches the id");
            }
            return errors;
        }

        public  List<string> Add(DepartmentEntity department)
        {
            DbContext.DepartmentRepository.Add(department);
            return DbContext.Commit();
        }

        public  List<string> Add(EmployeeLeaveEntity employeeLeave)
        {
            DbContext.EmployeeLeaveRepository.Add(employeeLeave);
            return DbContext.Commit();
        }
        public  List<string> Add(LeaveTypeEntity leaveType)
        {
            DbContext.LeaveTypeRepository.Add(leaveType);
            return DbContext.Commit();
        }

        public  List<string> Add(EmployeeEntity employee)
        {
            DbContext.EmployeeRepository.Add(employee);
            return DbContext.Commit();
        }

        public  List<string> Add(EmployeeTypeEntity employeeType)
        {
            DbContext.EmployeeTypeRepository.Add(employeeType);
            return DbContext.Commit();
        }

        public List<string> Add(LogEntity log)
        {
            DbContext.LogRepository.Add(log);
            return DbContext.Commit();
        }

        public  List<string> Edit(DepartmentEntity department)
        {
            DbContext.Entry(department).State = EntityState.Modified;
            return DbContext.Commit();
        }

        public  List<string> Edit(EmployeeEntity employee)
        {
            DbContext.Entry(employee).State = EntityState.Modified;
            return DbContext.Commit();
        }

        public  List<string> Edit(EmployeeLeaveEntity employeeLeave)
        {
            DbContext.Entry(employeeLeave).State = EntityState.Modified;
            return DbContext.Commit();
        }

        public  List<string> Edit(EmployeeTypeEntity employeeType)
        {
            DbContext.Entry(employeeType).State = EntityState.Modified;
            return DbContext.Commit();
        }

        public  List<string> Edit(LeaveTypeEntity leaveType)
        {
            DbContext.Entry(leaveType).State = EntityState.Modified;
            return DbContext.Commit();
        }

        public  IQueryable<DepartmentEntity> Departments(Expression<Func<DepartmentEntity, bool>> predicate)
        {
            return DbContext.DepartmentRepository.Find(predicate).AsQueryable();
        }

        public  IQueryable<LeaveTypeEntity> LeaveTypes(Expression<Func<LeaveTypeEntity, bool>> predicate)
        {
            return DbContext.LeaveTypeRepository.Find(predicate).AsQueryable();
        }

        public  IQueryable<EmployeeLeaveEntity> EmployeeLeaves(Expression<Func<EmployeeLeaveEntity, bool>> predicate)
        {
            return DbContext.EmployeeLeaveRepository.Find(predicate).AsQueryable();
        }

        public List<EmployeeEntity> GetAll()
        {
            return DbContext.EmployeeRepository.GetAll().ToList();
        }


    }
}