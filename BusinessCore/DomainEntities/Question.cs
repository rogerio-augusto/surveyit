using System;
using System.Collections.Generic;

namespace SurveyIt.Core.DomainEntities
{
    public class Question
    {
        public int Id { get; set; }

        public int SetpId { get; set; }

        public virtual Step Step { get; set; }

        public int Position { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Alternative> Alternatives { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
