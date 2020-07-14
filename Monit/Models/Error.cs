using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Monit.Models
{
    public class Error
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string StackTrace { get; set; }
        public string Source { get; set; }
        public string Path { get; set; }
    }
}
