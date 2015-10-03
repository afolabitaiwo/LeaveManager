using Business.Services.Managers.DataProviderManager.Interface;
using BusinessTemp.Services.Managers.LogManager.Interface;
using BusinessTemp.Services.Managers.NotificationManager.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaveManager.Managers.Interface
{
    public interface IHermit
    {
        void Processors(ILeaveCalendarDataProcessor lcDataProcessor, ILoggingProcessor loggingProcessor, INotificationProcessor notificationProcessor);
    }
}
