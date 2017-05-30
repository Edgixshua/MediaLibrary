using System;
using EdgixshuaMediaLibrary.VideoGames;
using EdgixshuaMediaLibrary.Database;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Shouldly;
using NUnit.Framework;
using EdgixshuaMediaLibrary.DataLayer;
using AutoMapper;

namespace MediaLibraryTests
{
    [TestFixture]
    public class RepositoryTests
    {
        public VideoGamesRespository Repository = new VideoGamesRespository();
        public MediaLibraryEntities Entities = new MediaLibraryEntities();

        [Test]
        public void ReturnVideoGame()
        {
            // Arrange
            Video_Games game = new Video_Games()
            {
                Title = "Rocket League",
                Edition = "Standard",
                Platform = "Playstation 4",
                Year = 2014
            };

            // Act
            Entities.Video_Games.Add(game);
            Entities.SaveChanges();

            var videoGame = Mapper.Map<List<VideoGame>>(Entities.Video_Games.FirstOrDefault());

            // Assert
            Assert.AreEqual("Rocket League", videoGame.Select(s => s.Title));
        }
    }
}
