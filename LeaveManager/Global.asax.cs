using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Mvc;
using System.Reflection;
using Business.Services.Managers.DataProviderManager.Concrete;
using Business.Services.Managers.DataProviderManager.Interface;
using BusinessTemp.Services.Managers.LogManager.Concrete;
using BusinessTemp.Services.Managers.LogManager.Interface;
using BusinessTemp.Services.Managers.NotificationManager.Concrete;
using BusinessTemp.Services.Managers.NotificationManager.Interface;

namespace LeaveManager
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);


            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<LeaveCalendarDataEFProcessor>().As<ILeaveCalendarDataProcessor>();
            builder.RegisterType<LoggingProcessor>().As<ILoggingProcessor>();
            builder.RegisterType<NotificationProcessor>().As<INotificationProcessor>();
     
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly())
                .Where(t => t.Name.EndsWith("Controller"));

            IContainer container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

        }
    }
}
