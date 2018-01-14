
namespace Kast.Models
{
    public class Topic
    {
        public int TopicId { get; set; }

        public string Name { get; set; }

        public string ThumnailImageUrl { get; set; }

        public PageRedirector pageRedirector { get; set; }

        public Category category { get; set; }
    }
}
