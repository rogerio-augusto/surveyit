namespace SurveyIt.Core.DomainEntities
{
    public class Step
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Visible { get; set; }
        public int Position { get; set; }
        public int HotsiteId { get; set; }
        public Hotsite Hotsite { get; set; }
    }
}
