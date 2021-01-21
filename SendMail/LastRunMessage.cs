using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SendMail
{
    internal class LastRunMessage
    {
        public long UIDValidity { get; set; }
        public long LargestUID { get; set; }
    }
}
