using System.ComponentModel.DataAnnotations;

namespace SurveyIt.MVC.ViewModels
{
    public class StepViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        public bool Visible { get; set; }
        
        [ScaffoldColumn(false)]
        public int Position { get; set; }
        public int HotsiteId { get; set; }
        public virtual HotsiteViewModel Hotsite { get; set; }
    }
}