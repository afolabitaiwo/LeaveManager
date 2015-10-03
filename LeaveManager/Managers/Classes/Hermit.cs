using Autofac.Core;
using Business.Services.Managers.DataProviderManager.Interface;
using BusinessTemp.Services.Managers.LogManager.Interface;
using BusinessTemp.Services.Managers.NotificationManager.Interface;
using LeaveManager.Managers.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeaveManager.Managers
{
    public class Hermit : IHermit
    {
        ILeaveCalendarDataProcessor _LeaveCalendarDataProcessor;
        ILoggingProcessor _LoggingProcessor;
        INotificationProcessor _NotificationProcessor;


        public void Processors(ILeaveCalendarDataProcessor lcDataProcessor, ILoggingProcessor loggingProcessor, INotificationProcessor notificationProcessor)
        {
            _LeaveCalendarDataProcessor = lcDataProcessor;
            _LoggingProcessor = loggingProcessor;
            _NotificationProcessor = notificationProcessor;

        }
    }
}