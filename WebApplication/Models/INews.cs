using Microsoft.AspNetCore.Http;

namespace WebApplication.Models
{
    public interface INews
    {
        public int Id { get; set; }
        public string ImagePath { get; set; }
        public string Heading { get; set; }
        public string NewsText { get; set; }
        public string Type { get; set; }
    }
}