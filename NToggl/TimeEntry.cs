using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NToggl
{
    public class TimeEntry
    {
        public string Description { get; set; }
        public int WorkspaceId { get; set; }
        public int ProjectId { get; set; }
        public int TaskId { get; set; }
        public bool Billable { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Duration { get; set; }
        public string CreatedWith { get; set; }
        public string[] Tags { get; set; }
        public bool DurationOnly { get; set; }
        public DateTime At { get; set; }
    }
}
