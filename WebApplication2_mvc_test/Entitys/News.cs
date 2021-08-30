namespace WebApplication2_mvc_test.Entitys
{
    public class News
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