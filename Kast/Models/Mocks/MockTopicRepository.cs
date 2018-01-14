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
                var homeCategory = new Category { CategoryId = 0, PageType = Page.Home };
                var rollplayingCategory = new Category { CategoryId = 1, PageType = Page.Roll };
                var paperCategory = new Category { CategoryId = 2, PageType = Page.Pape };

                var homeList = new List<Topic>
                {
                    new Topic{ TopicId = 0, Name="Kasper Steenstrup", category =homeCategory,
                        pageRedirector = new PageRedirector("Me", "Description", 0){PageRedirectorId=0},
                        ThumnailImageUrl ="https://media.licdn.com/mpr/mpr/shrinknp_200_200/p/2/000/18a/19d/253aae4.jpg"},
                    
                    new Topic{ TopicId = 3, Name="Rollplaying", category=homeCategory,
                        pageRedirector = new PageRedirector("Topic", "Home", 1){PageRedirectorId=1},
                        ThumnailImageUrl ="http://img06.deviantart.net/9a77/i/2013/094/0/9/roleplaying_group_by_justablink-d60fpzj.jpg"},

                    new Topic{ TopicId = 2, Name="Patens", category=homeCategory,
                        pageRedirector = new PageRedirector("Topic", "Home", 2){PageRedirectorId=2},
                        ThumnailImageUrl="https://ideas2market.files.wordpress.com/2013/03/patent1.jpg"},

                    new Topic{ TopicId = 1, Name="Puplications", category=homeCategory,
                        pageRedirector = new PageRedirector("Topic", "Home", 3){PageRedirectorId=3},
                        ThumnailImageUrl ="file:///C:/Users/kaspe/Desktop/homepage/image/papers.png"},

                    new Topic{ TopicId = 4, Name="Kast.dk", category=homeCategory,
                        pageRedirector = new PageRedirector("Topic", "Home", 4){PageRedirectorId=4},
                        ThumnailImageUrl ="https://media.licdn.com/mpr/mpr/shrinknp_200_200/p/2/000/18a/19d/253aae4.jpg"}
                };
                var rollplayingList = new List<Topic>
                {
                    new Topic{ TopicId = 5, Name = "Charitors", category = rollplayingCategory,
                        pageRedirector = new PageRedirector("Rollplaying", "Charitors", 0) { PageRedirectorId = 5 },
                        ThumnailImageUrl = "http://img06.deviantart.net/9a77/i/2013/094/0/9/roleplaying_group_by_justablink-d60fpzj.jpg"},

                    new Topic{ TopicId = 5, Name = "Items", category = rollplayingCategory,
                        pageRedirector = new PageRedirector("Rollplaying", "Items", 0) { PageRedirectorId = 5 },
                        ThumnailImageUrl = "http://img06.deviantart.net/9a77/i/2013/094/0/9/roleplaying_group_by_justablink-d60fpzj.jpg"},

                    new Topic{ TopicId = 5, Name = "Senarios 1", category = rollplayingCategory,
                        pageRedirector = new PageRedirector("Rollplaying", "Senarios", 0) { PageRedirectorId = 6 },
                        ThumnailImageUrl = "http://img06.deviantart.net/9a77/i/2013/094/0/9/roleplaying_group_by_justablink-d60fpzj.jpg"},

                    new Topic{ TopicId = 5, Name = "Senarios 2", category = rollplayingCategory,
                        pageRedirector = new PageRedirector("Rollplaying", "Senarios", 1) { PageRedirectorId = 5 },
                        ThumnailImageUrl = "http://img06.deviantart.net/9a77/i/2013/094/0/9/roleplaying_group_by_justablink-d60fpzj.jpg"},

                    new Topic{ TopicId = 5, Name = "Senarios 3", category = rollplayingCategory,
                        pageRedirector = new PageRedirector("Rollplaying", "Senarios", 2) { PageRedirectorId = 5 },
                        ThumnailImageUrl = "http://img06.deviantart.net/9a77/i/2013/094/0/9/roleplaying_group_by_justablink-d60fpzj.jpg"},
                    
                    new Topic{ TopicId = 5, Name = "Senarios 4", category = rollplayingCategory,
                        pageRedirector = new PageRedirector("Rollplaying", "Senarios", 3) { PageRedirectorId = 5 },
                        ThumnailImageUrl = "http://img06.deviantart.net/9a77/i/2013/094/0/9/roleplaying_group_by_justablink-d60fpzj.jpg"},

                    new Topic{ TopicId = 5, Name = "Senarios 5", category = rollplayingCategory,
                        pageRedirector = new PageRedirector("Rollplaying", "Senarios", 4) { PageRedirectorId = 6 },
                        ThumnailImageUrl = "http://img06.deviantart.net/9a77/i/2013/094/0/9/roleplaying_group_by_justablink-d60fpzj.jpg"},

                    new Topic{ TopicId = 5, Name = "Senarios 6", category = rollplayingCategory,
                        pageRedirector = new PageRedirector("Rollplaying", "Senarios", 5) { PageRedirectorId = 5 },
                        ThumnailImageUrl = "http://img06.deviantart.net/9a77/i/2013/094/0/9/roleplaying_group_by_justablink-d60fpzj.jpg"},

                    new Topic{ TopicId = 5, Name = "Senarios 7", category = rollplayingCategory,
                        pageRedirector = new PageRedirector("Rollplaying", "Senarios", 6) { PageRedirectorId = 5 },
                        ThumnailImageUrl = "http://img06.deviantart.net/9a77/i/2013/094/0/9/roleplaying_group_by_justablink-d60fpzj.jpg"}
                };

                homeList.AddRange(rollplayingList);
                
                return homeList;
            }
        }

        public Topic GetTopicById(int topicId)
        {
            throw new NotImplementedException();
        }
    }
}
