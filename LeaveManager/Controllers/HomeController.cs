
using Business.Services.Contexts.Validatiion;
using Business.Services.Managers.DataProviderManager.Interface;
using BusinessTemp.Services.Managers.LogManager.Interface;
using BusinessTemp.Services.Managers.NotificationManager.Interface;
using LeaveManager.Managers;
using LeaveManager.Managers.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LeaveManager.Controllers
{
    public class HomeController : Controller
    {

        public HomeController(ILeaveCalendarDataProcessor lcDataProcessor, ILoggingProcessor loggingProcessor, INotificationProcessor notificationProcessor)
        {
            _LeaveCalendarDataProcessor = lcDataProcessor;
            _LoggingProcessor = loggingProcessor;
            _NotificationProcessor = notificationProcessor;
        }

      

        ILeaveCalendarDataProcessor _LeaveCalendarDataProcessor;
        ILoggingProcessor _LoggingProcessor;
        INotificationProcessor _NotificationProcessor;
        // GET: Home


        public ActionResult Index()
        {
            List<DepartmentEntity> department = _LeaveCalendarDataProcessor.Departments(x => x.Name == "IT Department").ToList();

            return View();

        }
    }
}