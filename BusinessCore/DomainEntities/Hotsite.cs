using System;
using System.Collections.Generic;

namespace SurveyIt.Core.DomainEntities
{
    public class Hotsite
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Published { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public virtual IEnumerable<Step> Steps { get; set; }

        public bool IsOpen()
        {
            return this.Published && this.Deadline >= DateTime.Now;
        }
    }
}
