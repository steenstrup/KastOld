using Microsoft.AspNetCore.Mvc;
using Kast.Models;
using System.Linq;

namespace Kast.Controllers
{
    public class TopicController : Controller
    {
        private readonly ITopicRepository _topicRepository;

        public TopicController(ITopicRepository topicRepository)
        {
            _topicRepository = topicRepository;
        }
        
        public ViewResult Home(int id)
        {
            return View(_topicRepository.Topics.Where(x => x.category.PageType == (Page)id));
        }

    }
}
