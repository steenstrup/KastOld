namespace Kast.Models
{
    public class PageRedirector
    {
        public PageRedirector(string controler, string action, int id)
        {
            _controller = controler;
            _action = action;
            _id = id;
        }

        public int PageRedirectorId { get; set; }

        private string _controller;

        private string _action;

        private int _id;

        public string GetUrl()
        {
            return _controller + "\\" + _action + "\\" + _id;
        }

    }
}