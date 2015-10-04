using BusinessTemp.Services.Managers.NotificationManager.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTemp.Services.Managers.NotificationManager.Concrete
{
     public class NotificationProcessor : INotificationProcessor
    {
        void INotificationProcessor.SendReceipt(string message)
        {
            // send email to customer with receipt            
        }
    }
}
