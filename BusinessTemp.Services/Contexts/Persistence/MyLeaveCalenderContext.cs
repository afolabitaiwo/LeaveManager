using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Business.Services.Contexts.Validatiion;
using Business.Services.Contexts.Persistence.Configuration;
using Business.Services.Contexts.Persistence.Concrete;
using Business.Services.Contexts.Persistence.Interfaces;
using BusinessTemp.Services.Properties;
using System.Data.Entity.Validation;
using System.Data.Entity.Infrastructure;
using LinqKit;



namespace Business.Services.Contexts.Persistence
{
    public class MyLeaveCalenderContext : DbContext, IUnitOfWork
    {
        private EntityFrameworkRepository<EmployeeEntity> _EmployeeRepo;
        private EntityFrameworkRepository<DepartmentEntity> _DepartmentRepo;
        private EntityFrameworkRepository<EmployeeLeaveEntity> _EmployeeLeaveRepo;
        private EntityFrameworkRepository<EmployeeTypeEntity> _EmployeeTypeRepo;
        private EntityFrameworkRepository<LeaveTypeEntity> _LeaveTypeRepo;
        private EntityFrameworkRepository<LogEntity> _LogRepo;



        public DbSet<EmployeeEntity> Employee { get; set; }
        public DbSet<DepartmentEntity> Department { get; set; }
        public DbSet<EmployeeLeaveEntity> EmployeeLeave { get; set; }
        public DbSet<EmployeeTypeEntity> EmployeeType { get; set; }
        public DbSet<LeaveTypeEntity> LeaveType { get; set; }
        public DbSet<LogEntity> Log { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();         
            modelBuilder.Configurations.Add(new RecordStateConfiguration());
        }


        #region IUnitOfWork Implementation
        public IGenericRepository<EmployeeEntity> EmployeeRepository
        {
            get
            {
                return _EmployeeRepo;
            }
        }

        public IGenericRepository<EmployeeLeaveEntity> EmployeeLeaveRepository
        {
            get
            {
                return _EmployeeLeaveRepo;
            }
        }

        public IGenericRepository<EmployeeTypeEntity> EmployeeTypeRepository
        {
            get
            {
                return _EmployeeTypeRepo;
            }
        }

        public IGenericRepository<DepartmentEntity> DepartmentRepository
        {
            get
            {
                return _DepartmentRepo;
            }
        }

        public IGenericRepository<LeaveTypeEntity> LeaveTypeRepository
        {
            get
            {
                return _LeaveTypeRepo;
            }
        }

        public IGenericRepository<LogEntity> LogRepository
        {
            get
            {
                return _LogRepo;
            }
        }

        public List<string> Commit()
        {
            var errors = new List<string>();
            try
            {
                this.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                e.EntityValidationErrors.ForEach(
                    x => x.ValidationErrors.ForEach(
                        y => errors.Add(x.Entry.Entity.GetType().ToString() + ": " + y.ErrorMessage)));
            }
            catch (DbUpdateException e)
            {
                errors.Add(e.InnerException.Source.Split('.').LastOrDefault() + ": " +
                           e.InnerException.InnerException.Message);
            }
            return errors;

        }

        #endregion


        public MyLeaveCalenderContext()
            : base(Settings.Default.MyLeaveCalenderContext)
        {

            this.SetConcreteRepositories();
        }

        private void SetConcreteRepositories()
        {
            _DepartmentRepo = new EntityFrameworkRepository<DepartmentEntity>(this);
            _EmployeeLeaveRepo = new EntityFrameworkRepository<EmployeeLeaveEntity>(this);
            _EmployeeRepo = new EntityFrameworkRepository<EmployeeEntity>(this);
            _EmployeeTypeRepo = new EntityFrameworkRepository<EmployeeTypeEntity>(this);
            _LeaveTypeRepo = new EntityFrameworkRepository<LeaveTypeEntity>(this);
            _LogRepo = new EntityFrameworkRepository<LogEntity>(this);

        }
    }

   
}