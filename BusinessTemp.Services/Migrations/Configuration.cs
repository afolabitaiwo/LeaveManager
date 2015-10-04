namespace BusinessTemp.Services.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Business.Services.Contexts.Persistence.MyLeaveCalenderContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;

        }

        protected override void Seed(Business.Services.Contexts.Persistence.MyLeaveCalenderContext context)
        {
            //This method will be called after migrating to the latest version.

            //You can use the DbSet<T>.AddOrUpdate() helper extension method
            //to avoid creating duplicate seed data.E.g.

              //context.Department.AddOrUpdate(
              //  p => p.DepartmentId,
              //  new Department() { DepartmentId = 1,  },
                
              //);

        }
    }
}
