namespace WebApplication.Models
{
    public class News : INews
    {
        public enum NewsType
        {
            Politics,
            Society,
            Economics,
            Worlds,
            Accidents,
            Sports,
            Sciences,
            Tourism
        }
        
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Heading { get; set; }
        public string NewsText { get; set; }
        public string Type { get; set; }
    }
}