using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EdgixshuaMediaLibrary.VideoGames;
using EdgixshuaMediaLibrary.Database;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Shouldly;

namespace MediaLibraryTests
{
    [TestClass]
    public class RepositoryTests
    {
        public MediaLibraryEntities Entities = new MediaLibraryEntities();

        [TestMethod]
        public void ReturnVideoGame()
        {
            //Arrange
            //var videoGame = new VideoGame();
            //string gameTitle = "Rocket League";

            //Act
            //videoGame = Entities.Video_Games.FirstOrDefault();

            //Assert
            //videoGame.Title.ShouldBe(gameTitle);

        }
    }
}
