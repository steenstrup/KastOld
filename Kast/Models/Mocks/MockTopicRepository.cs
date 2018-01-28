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
                var charitorCategory = new Category { CategoryId = 3, PageType = Page.Char };

                var homeList = new List<Topic>
                {
                    new Topic{ TopicId = 0, Name="Kasper Steenstrup", category =homeCategory,
                        pageRedirector = new PageRedirector("Me", "Description", 0){PageRedirectorId=0},
                        ThumnailImageUrl ="/Images/Me.png"},
                    
                    new Topic{ TopicId = 3, Name="Rollplaying", category=homeCategory,
                        pageRedirector = new PageRedirector("Topic", "Home", 1){PageRedirectorId=1},
                        ThumnailImageUrl ="http://img06.deviantart.net/9a77/i/2013/094/0/9/roleplaying_group_by_justablink-d60fpzj.jpg"},

                    new Topic{ TopicId = 2, Name="Patens", category=homeCategory,
                        pageRedirector = new PageRedirector("Topic", "Home", 2){PageRedirectorId=2},
                        ThumnailImageUrl="https://ideas2market.files.wordpress.com/2013/03/patent1.jpg"},

                    new Topic{ TopicId = 1, Name="Puplications", category=homeCategory,
                        pageRedirector = new PageRedirector("Topic", "Home", 3){PageRedirectorId=3},
                        ThumnailImageUrl ="/Images/Papers.png"},

                    new Topic{ TopicId = 4, Name="Kast.dk", category=homeCategory,
                        pageRedirector = new PageRedirector("Topic", "Home", 4){PageRedirectorId=4},
                        ThumnailImageUrl ="https://media.licdn.com/mpr/mpr/shrinknp_200_200/p/2/000/18a/19d/253aae4.jpg"}
                };

                var rollplayingList = new List<Topic>
                {
                    new Topic{ TopicId = 5, Name = "Charitors", category = rollplayingCategory,
                        pageRedirector = new PageRedirector("Topic", "Home", 3){PageRedirectorId=4},
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

                var hummingbirdUrl = "https://lh3.googleusercontent.com/4Yg5s5S0UCM7NlEsTvXqY3p2Fgtskj2JC4rFWF_vIjVrSfKG3cRUFbs3u-AxA0dVxnsQX4953RsbKLkRFgMd619YMtxh6Mcm79vpFI5MJVRtpcXEUMRXaPHGDBO_vlAHkeAIlD7Uy8LPC_fbKV39czYte67ji5EFZ16JUCrV06-w6lTgiY5pAbg2hlbh5E_RIxLumU3gfGDJUnNEB9vZXN8PaaiU7pD1YIO32dxilzVcGziJ1UVTFfNrwlgBrP8Id1hJWJ2-ZnsTlQkHx4ljItp4NSSnV_uzKt-QKXcxK0F1qzZ64YNNllS6IRBk-uPVQin-gx1mjoWd2c_1xiMkNOr-9PdQoJs3k9HH95gImia3ZoDKFDgcWv6USc2Y2RaSKPLdG4VEmndo_NSwUNyLyn_pkO22Nm3te9bmpyHq52qVPzds6rdnAzhJxqy2U5Na7la7IZHeqmwneZdZ_iKO2RdSuSHetilfF5YWnAwBj75dslfKzEZLJ_WzxpSZLYKqqcSRRwKmE6geiC7gcprxXY4KOK9a3BsXcVa4zTw88r2NfY9rpIhbtcX6mPWXMz8_EKvkdJLiUxD7iByiLfAvojy-7Q_JCA11rZGpSGie=w673-h471-no";

                var CharitorsList = new List<Topic>
                {
                    new Topic{ TopicId = 5, Name = "Ajaton", category = charitorCategory,
                        pageRedirector = new PageRedirector("Rollplaying", "Dnd5ECharaters", 0){PageRedirectorId=0},
                        ThumnailImageUrl ="/Images/Rollplaying/Ajaton.jpg"},

                     new Topic{ TopicId = 5, Name = "Akesera", category = charitorCategory,
                        pageRedirector = new PageRedirector("Rollplaying", "Dnd5ECharaters", 1){PageRedirectorId=0},
                        ThumnailImageUrl = "/Images/Rollplaying/Akesera.jpg"},

                     new Topic{ TopicId = 5, Name = "Birgita", category = charitorCategory,
                        pageRedirector = new PageRedirector("Rollplaying", "Dnd5ECharaters", 2){PageRedirectorId=0},
                        ThumnailImageUrl = "/Images/Rollplaying/Birgita.jpg"},

                      new Topic{ TopicId = 5, Name = "Filex", category = charitorCategory,
                        pageRedirector = new PageRedirector("Rollplaying", "Dnd5ECharaters", 3){PageRedirectorId=0},
                        ThumnailImageUrl = "/Images/Rollplaying/Felix.jpg"},

                       new Topic{ TopicId = 5, Name = "Hummingbird", category = charitorCategory,
                        pageRedirector = new PageRedirector("Rollplaying", "Dnd5ECharaters", 4){PageRedirectorId=0},
                        ThumnailImageUrl = "/Images/Rollplaying/Hummingbird.jpg"}
                };

                var PaperList = new List<Topic>
                {
                    new Topic{ TopicId = 0, Name = "Gravity Modeling (Idea)", category = paperCategory,
                        pageRedirector = new PageRedirector("Papers", "GravityModeling", 0){PageRedirectorId=0},
                        ThumnailImageUrl = hummingbirdUrl},

                    new Topic{ TopicId = 0, Name = "Elastica Segmentation (70%)", category = paperCategory,
                        pageRedirector = new PageRedirector("Papers", "ElasticaSegmentation", 0){PageRedirectorId=0},
                        ThumnailImageUrl = hummingbirdUrl},

                    new Topic{ TopicId = 0, Name = "Block Segmentation (99%)", category = paperCategory,
                        pageRedirector = new PageRedirector("Papers", "BlockSegmentation", 0){PageRedirectorId=0},
                        ThumnailImageUrl = hummingbirdUrl},

                    new Topic{ TopicId = 0, Name = "Cuttable ruled surface strips for milling", category = paperCategory,
                        pageRedirector = new PageRedirector("Papers", "CuttableRuledSurfaceStripsForMilling", 0){PageRedirectorId=0},
                        ThumnailImageUrl = hummingbirdUrl},

                    new Topic{ TopicId = 0, Name = "Hot-blade Cutting for the Building Industries", category = paperCategory,
                        pageRedirector = new PageRedirector("Papers", "HotBladeCuttingfortheBuildingIndustries", 0){PageRedirectorId=0},
                        ThumnailImageUrl = hummingbirdUrl},

                    new Topic{ TopicId = 0, Name = "Robotic Hot-blade Cutting", category = paperCategory,
                        pageRedirector = new PageRedirector("Papers", "RoboticHotBladeCutting", 0){PageRedirectorId=0},
                        ThumnailImageUrl = hummingbirdUrl},

                    new Topic{ TopicId = 0, Name = "VirtualTable", category = paperCategory,
                        pageRedirector = new PageRedirector("Papers", "VirtualTable", 0){PageRedirectorId=0},
                        ThumnailImageUrl = hummingbirdUrl},

                    new Topic{ TopicId = 0, Name = "Surfce rationalization for Hot-wire and Hot-blade", category = paperCategory,
                        pageRedirector = new PageRedirector("Papers", "SurfceRationalizationForHotWireAndHotBlade", 0){PageRedirectorId=0},
                        ThumnailImageUrl = hummingbirdUrl},

                    new Topic{ TopicId = 0, Name = "Surfce rationalization for Hot-wire and Hot-blade", category = paperCategory,
                        pageRedirector = new PageRedirector("Papers", "SurfceRationalizationForHotWireAndHotBlade", 1){PageRedirectorId=0},
                        ThumnailImageUrl = hummingbirdUrl}
                };
                
                homeList.AddRange(rollplayingList);
                homeList.AddRange(CharitorsList);
                homeList.AddRange(PaperList);
                return homeList;
            }
        }

        public Topic GetTopicById(int topicId)
        {
            throw new NotImplementedException();
        }
    }
}
