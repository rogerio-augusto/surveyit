using System.Collections.Generic;

namespace SurveyIt.MVC.ViewModels
{
    public class QuestionViewModel
    {
        public int Id { get; set; }

        public int SetpId { get; set; }

        public StepViewModel Step { get; set; }

        public int Position { get; set; }

        public string Description { get; set; }

        public virtual IEnumerable<AlternativeViewModel> Alternatives { get; set; }
    }
}