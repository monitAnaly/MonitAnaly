using System;
using System.Collections.Generic;
using System.Text;

namespace Analy.Models
{
    public class Error
    {
        public string Key { get; set; }
        public string StackTrace { get; set; }
        public string Source { get; set; }
        public string Path { get; set; }
    }
}
