using System;
using EdgixshuaMediaLibrary.DataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using AutoMapper;
using EdgixshuaMediaLibrary.VideoGames.Database;
using Shouldly;
using System.Collections.Generic;
using Moq;
using System.Linq;

namespace MediaLibraryTests
{
    [TestClass]
    public class RepositoryTests
    {
        private MediaLibraryEntities _entities = new MediaLibraryEntities();

        private VideoGamesRespository _repository = new VideoGamesRespository();

        MappingConfig config = new MappingConfig();

        [TestMethod]
        public void VideoGameMapping()
        {
            MappingConfig config = new MappingConfig();

            config.SetupMappings();

            Mapper.AssertConfigurationIsValid();
        }

        private VideoGamesRespository SetupMockRepository()
        {
            config.SetupMappings();

            var games = new List<Video_Games>()
            {
                new Video_Games
                {
                    Title = "Rocket League",
                    Edition = "Standard",
                    Platform = "Playstation 4",
                    Year = 2014
                },
                new Video_Games
                {
                    Title = "Dragonball Budokai Tenkaichi 2",
                    Edition = "Standard",
                    Platform = "Wii",
                    Year = 2007
                },
                new Video_Games
                {
                    Title = "Alien Isolation",
                    Edition = "Standard",
                    Platform = "Playstation 4",
                    Year = 2014
                },
                new Video_Games
                {
                    Title = "Metroid Prime",
                    Edition = "Standard",
                    Platform = "Gamecube",
                    Year = 2002
                }
            };

            var mockSet = new Mock<DbSet<Video_Games>>();
            mockSet.As<IQueryable<Video_Games>>().Setup(m => m.Provider).Returns(games.AsQueryable().Provider);
            mockSet.As<IQueryable<Video_Games>>().Setup(m => m.Expression).Returns(games.AsQueryable().Expression);
            mockSet.As<IQueryable<Video_Games>>().Setup(m => m.ElementType).Returns(games.AsQueryable().ElementType);
            mockSet.As<IQueryable<Video_Games>>().Setup(m => m.GetEnumerator()).Returns(games.AsQueryable().GetEnumerator());
            mockSet.Setup(m => m.Add(It.IsAny<Video_Games>())).Callback<Video_Games>(game => games.Add(game));

            var mockContext = new Mock<MediaLibraryEntities>();
            mockContext.Setup(s => s.Video_Games).Returns(mockSet.Object);

            var mockRepo = new VideoGamesRespository(mockContext.Object);

            return mockRepo;
        }

        [TestMethod]
        public void ReturnVideoGame()
        {
            var mockRepo = SetupMockRepository();
            var gameList = mockRepo.ReturnAll();

            gameList.ShouldNotBeNull();
        }

        [TestMethod]
        public void CheckIfVideoGameExists()
        {
            var mockRepo = SetupMockRepository();
            var game = mockRepo.IfExists("Rocket League", "Standard", "Playstation 4");

            game.ShouldNotBeNull();
        }

        [TestMethod]
        public void ReturnEnitireVideoGameLibrary()
        {
            var mockRepo = SetupMockRepository();
            var gameList = mockRepo.ReturnAll();

            gameList.First().Title.ShouldBe("Rocket League");
            gameList.Last().Title.ShouldBe("Metroid Prime");
        }

        [TestMethod]
        public void ReturnVideoGamesByPlatform()
        {
            var mockRepo = SetupMockRepository();
            var gameList = mockRepo.PlatformSearch("Gamecube");

            gameList.First().Title.ShouldBe("Metroid Prime");
        }

        [TestMethod]
        public void ReturnVideoGamesByExactTitle()
        {
            var mockRepo = SetupMockRepository();
            var gameList = mockRepo.TitleSearch("Dragonball Budokai Tenkaichi 2");

            gameList.First().Title.ShouldBe("Dragonball Budokai Tenkaichi 2");
        }

        [TestMethod]
        public void ReturnVideoGamesByTitleContainingWord()
        {
            var mockRepo = SetupMockRepository();
            var gameList = mockRepo.TitleSearch("Dragon");

            gameList.First().Title.ShouldBe("Dragonball Budokai Tenkaichi 2");
        }

        [TestMethod]
        public void AddNewGameToRepo()
        {
            var mockRepo = SetupMockRepository();
            mockRepo.Add("FIFA 17", "Standard", "Playstation 4", 2016);

            mockRepo.Entities.Video_Games.Last().Title.ShouldBe("FIFA 17");
        }
    }
}

