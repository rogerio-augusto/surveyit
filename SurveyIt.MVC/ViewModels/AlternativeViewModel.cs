namespace SurveyIt.MVC.ViewModels
{
    public class AlternativeViewModel
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }

        public QuestionViewModel Question { get; set; }

        public int Position { get; set; }

        public string Description { get; set; }

        public bool IsCorrect { get; set; }
    }
}