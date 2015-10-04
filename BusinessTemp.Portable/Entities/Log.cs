using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Portable.Enums;

namespace Business.Portable.Entities
{
    public class Log
    {
        public virtual int LogId { get; set; }
        public virtual string Source { get; set; }
        public virtual string Message { get; set; }
        public virtual LogType LogType { get; set; }
        public virtual string CreatedByUserId { get; set; }
        public virtual DateTime CreatedDateTime { get; set; }
    }
}
