
using System;
namespace SurveyIt.Core.DomainEntities
{
    public class Alternative
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }

        public virtual Question Question { get; set; }

        public int Position { get; set; }

        public string Description { get; set; }

        public bool IsCorrect { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
