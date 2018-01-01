using System;
using System.Collections.Generic;

namespace Kast.Models
{
    public class MockTopicRepository : ITopicRepository
    {
        public IEnumerable<Topic> Topics
        {
            get
            {
                return new List<Topic>
                {
                    new Topic{ TopicId = 0, Name="Kasper Steenstrup", ControllerName="Me", ActionName="Me", ThumnailImageUrl="https://media.licdn.com/mpr/mpr/shrinknp_200_200/p/2/000/18a/19d/253aae4.jpg"},
                    new Topic{ TopicId = 1, Name="Puplications", ControllerName="Me", ActionName="Me", ThumnailImageUrl="https://media.licdn.com/mpr/mpr/shrinknp_200_200/p/2/000/18a/19d/253aae4.jpg"},
                    new Topic{ TopicId = 2, Name="Patens", ControllerName="Me", ActionName="Me", ThumnailImageUrl="https://media.licdn.com/mpr/mpr/shrinknp_200_200/p/2/000/18a/19d/253aae4.jpg"},
                    new Topic{ TopicId = 3, Name="Rollplaying", ControllerName="Me", ActionName="Me", ThumnailImageUrl="https://media.licdn.com/mpr/mpr/shrinknp_200_200/p/2/000/18a/19d/253aae4.jpg"},
                    new Topic{ TopicId = 3, Name="Kast.dk", ControllerName="Me", ActionName="Me", ThumnailImageUrl="https://media.licdn.com/mpr/mpr/shrinknp_200_200/p/2/000/18a/19d/253aae4.jpg"}
                };
            }
        }

        public Topic GetTopicById(int topicId)
        {
            throw new NotImplementedException();
        }
    }
}
