using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading;

namespace Business.Services.Contexts.Persistence
{
    public class PersistResponse
    {
        public object PrimaryKey { get; set; }
        public List<string> Error { get; set; }
        public bool HasError()
        {
            return Error.Count > 0;
        }
    }
}