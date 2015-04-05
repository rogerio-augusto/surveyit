using System;
using System.Collections.Generic;
namespace SurveyIt.Core.DomainEntities
{
    public class Step
    {
        public int Id { get; set; }

        public string Title { get; set; }
        
        public bool Visible { get; set; }
        
        public int Position { get; set; }
        
        public int HotsiteId { get; set; }
        
        public virtual Hotsite Hotsite { get; set; }

        public virtual ICollection<Question> Questions { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
