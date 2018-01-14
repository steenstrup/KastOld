
using System.Collections.Generic;

namespace Kast.Models
{
    public interface ITopicRepository
    {

        IEnumerable<Topic> Topics { get; }

        Topic GetTopicById(int topicId);

    }
}
