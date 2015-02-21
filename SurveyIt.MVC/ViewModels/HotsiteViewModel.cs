using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SurveyIt.MVC.ViewModels
{
    public class HotsiteViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        [MinLength(2)]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Published { get; set; }
        public DateTime Deadline { get; set; }
        
        [ScaffoldColumn(false)]
        public DateTime CreatedAt { get; set; }

        [ScaffoldColumn(false)]
        public DateTime UpdatedAt { get; set; }
        public virtual IEnumerable<StepViewModel> Steps { get; set; }
    }
}