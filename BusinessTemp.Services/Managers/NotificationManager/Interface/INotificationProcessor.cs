using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTemp.Services.Managers.NotificationManager.Interface
{
     public  interface INotificationProcessor
    {
        void SendReceipt(string message);
    }
}
