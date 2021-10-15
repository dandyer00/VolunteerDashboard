using System;
using System.Collections.Generic;

#nullable disable

namespace Hack29_WebApp.DatabaseLayer.Models
{
    public partial class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public int UserId { get; set; }
        public byte[] EventTime { get; set; }
        public string WorkflowInstanceId { get; set; }
    }
}
