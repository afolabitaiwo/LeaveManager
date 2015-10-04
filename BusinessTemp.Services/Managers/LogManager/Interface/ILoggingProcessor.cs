using Business.Services.Contexts.Validatiion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTemp.Services.Managers.LogManager.Interface
{
    public interface ILoggingProcessor
    {
        List<string> Add(LogEntity log);
    }
}
