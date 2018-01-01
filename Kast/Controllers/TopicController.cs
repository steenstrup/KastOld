using Microsoft.AspNetCore.Mvc;
using Kast.Models;

namespace Kast.Controllers
{
    public class TopicController : Controller
    {
        private readonly ITopicRepository _topicRepository;

        public TopicController(ITopicRepository topicRepository)
        {
            _topicRepository = topicRepository;
        }


        public ViewResult List()
        {
            return View(_topicRepository.Topics);
        }
    }
}
