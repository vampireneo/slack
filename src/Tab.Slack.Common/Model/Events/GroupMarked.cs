using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tab.Slack.Common.Model.Events
{
    public class GroupMarked : EventMessageBase
    {
        public string Channel { get; set; }
        public string Ts { get; set; }
    }
}

