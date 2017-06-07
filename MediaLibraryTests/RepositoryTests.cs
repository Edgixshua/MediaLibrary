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

            //_repository.AddNewGame(new Database.Video_Games()
            //{
            //    Title = "Rocket League",
            //    Edition = "Standard,
            //    Platform = "Playstation 4",
            //    Year = 2014
            //});

            _entities.Video_Games.Add(new Video_Games { Title = "Rocket League", Edition = "Standard", Platform = "Playstation 4", Year = 2014 });
            _entities.Video_Games.Add(new Video_Games { Title = "Uncharted 4", Edition = "Standard", Platform = "Playstation 4", Year = 2016 });
            _entities.SaveChanges();
        }

        [TestMethod]
        public void AddNewVideoGame()
        {
            var fakeLibrary = new FakeMediaLibraryEntities();
            var repo = new VideoGamesRespository(fakeLibrary);
            
           

            //repo.AddNewGame(new Video_Games
            //{
            //    Title = "Rocket League",
            //    Edition = "Standard,
            //    Platform = "Playstation 4",
            //    Year = 2014
            //}).ShouldBe(1);
        }
    }
    
    public class FakeMediaLibraryEntities : MediaLibraryEntities
    {
        public List<Video_Games> Games { get; set; }
        int _rowsAltered;

        public FakeMediaLibraryEntities() : this(0) {
        }

        public FakeMediaLibraryEntities(int rowsAltered) {
            _rowsAltered = rowsAltered;
            Games = new List<Video_Games>();
        }

        public override int SaveChanges()
        {
            return _rowsAltered;
        }

        //public override DbSet<Video_Games> Video_Games {
        //    get => {
        //        var dataset = new DbSet<Video_Games>();
        //    }
        //    set => base.Video_Games = value;
        //}
    }
}

