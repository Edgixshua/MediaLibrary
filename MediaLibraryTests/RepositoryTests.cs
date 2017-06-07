using EdgixshuaMediaLibrary.DataLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;
using AutoMapper;
using EdgixshuaMediaLibrary.Database;
using Shouldly;
using EdgixshuaMediaLibrary.VideoGames;
using System.Collections.Generic;
using Moq;

namespace MediaLibraryTests
{
    [TestClass]
    public class RepositoryTests
    {
        private MediaLibraryEntities _entities = new MediaLibraryEntities();

        private VideoGamesRespository _repository = new VideoGamesRespository();

        [TestMethod]
        public void VideoGameMapping()
        {
            MappingConfig config = new MappingConfig();

            config.SetupMappings();

            Mapper.AssertConfigurationIsValid();
        }

        public void MockVideoGameTable()
        {
            var mockDbSet = new Mock<DbSet<Video_Games>>();
            var mockContext = new Mock<MediaLibraryEntities>();

            mockContext.Setup(s => s.Video_Games).Returns(mockDbSet.Object);

            _repository.AddNewGame("Rocket League", "Standard", "Playstation 4", 2014);

            _entities.Video_Games.Add(new Video_Games { Title = "Rocket League", Edition = "Standard", Platform = "Playstation 4", Year = 2014 });
            _entities.Video_Games.Add(new Video_Games { Title = "Uncharted 4", Edition = "Standard", Platform = "Playstation 4", Year = 2016 });
            _entities.SaveChanges();
        }

        [TestMethod]
        public void AddNewVideoGame()
        {
            var mockDbSet = new Mock<DbSet<Video_Games>>();
            List<VideoGame> expectedMapping = new List<VideoGame>();

            var entities = new MediaLibraryEntities()
            {
                //Video_Games = mockDbSet
            };
            var repo = new VideoGamesRespository(_entities);

            var mapped = repo.GetEntireVideoGameLibrary();
            mapped.ShouldBe(expectedMapping);
        }
    }
}

