using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tab.Slack.Common.Model.Events
{
    public class FilePrivate : EventMessageBase
    {
        public string File { get; set; }
    }
}

