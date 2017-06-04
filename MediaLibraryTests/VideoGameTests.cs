using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EdgixshuaMediaLibrary.VideoGames;
using Shouldly;

namespace MediaLibraryTests
{
    [TestClass]
    public class VideoGameTests
    {
        [TestMethod]
        public void VideoGameHasCorrectProperties()
        {
            VideoGame game = new VideoGame()
            {
                Title = "Rocket League",
                Edition = "Standard",
                Platform = "Playstation 4",
                Year = 2014
            };

            game.Title.ShouldBe("Rocket League");
            game.Edition.ShouldBe("Standard");
            game.Platform.ShouldBe("Playstation 4");
            game.Year.ShouldBe(2014);
        }
    }
}
