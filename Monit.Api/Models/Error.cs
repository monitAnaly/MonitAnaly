using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monit.Api.Models
{
    public class Error
    {
        public string Key { get; set; }
        public string StackTrace { get; set; }
        public string Source { get; set; }
        public string Path { get; set; }
    }
}
