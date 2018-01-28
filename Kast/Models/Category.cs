namespace Kast.Models
{

    public enum Page{ Home, Roll, Pape, Char};

    public class Category
    {
        public int CategoryId { get; set; }

        public Page PageType { get; set; }
        
    }
}