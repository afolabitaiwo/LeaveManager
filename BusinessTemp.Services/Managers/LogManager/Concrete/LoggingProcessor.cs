using Business.Portable.Enums;
using Business.Services.Contexts.Persistence;
using Business.Services.Contexts.Validatiion;
using BusinessTemp.Services.Managers.LogManager.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTemp.Services.Managers.LogManager.Concrete
{
    public class LoggingProcessor : ILoggingProcessor
    {
        public List<string> Add(LogEntity log)
        {
            

            List<string> errors = new List<string>();

            try
            {
                using (var entity = new MyLeaveCalenderContext())
                {
                    entity.LogRepository.Add(log);

                    errors = entity.Commit();
                }
            }
            catch (Exception ex)
            {
                try
                {
                    LogEntity dbLogError = new LogEntity
                    {
                        LogType = LogType.Error,
                        Message = "Failed to add error log to database." + ex.ToString(),
                        Source = "Business.Services.Managers.LogManager.Logger | Add",
                        CreatedByUserId = String.Empty,
                        CreatedDateTime = DateTime.UtcNow
                    };

                    //Task dbErrorEmailTask = NotifyByMailAsync(dbLogError, log);
                }
                catch { }
            }

            return errors;
        }     
      
    }
}
