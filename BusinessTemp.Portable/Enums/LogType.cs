using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Portable.Enums
{
    public enum LogType
    {
        Error=1,
        Event=2,
        Information=3,
        DomainWebRequestError=4,
        ExternalWebRequestError=5,       
    }
}
