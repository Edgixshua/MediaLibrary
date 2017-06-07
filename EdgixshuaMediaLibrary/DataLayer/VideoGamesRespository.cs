using AutoMapper;
using EdgixshuaMediaLibrary.Database;
using EdgixshuaMediaLibrary.VideoGames;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace EdgixshuaMediaLibrary.DataLayer
{
    public class FakeVideoGamesRespository : VideoGamesRespository
    {
        protected override List<VideoGame> Map(object value)
        {
            return null;
        }
    }

    public class VideoGamesRespository
    {
        public MediaLibraryEntities Entities;
        

        public VideoGamesRespository()
        {
            Entities = new MediaLibraryEntities();
        }

        public VideoGamesRespository(MediaLibraryEntities entities) 
        {
            Entities = entities;
        }

        protected virtual List<VideoGame> Map(object value) {
            return Mapper.Map<List<VideoGame>>(value);
        }

        public List<VideoGame> GetEntireVideoGameLibrary()
        {
            return Map(Entities.Video_Games.ToList());
        }

        public List<VideoGame> SearchByPlatform(string platformName)
        {
            return Mapper.Map<List<VideoGame>>(Entities.Video_Games.Where(w => w.Platform == platformName).ToList());
        }

        public List<VideoGame> SearchByTitle(string title)
        {
            return Mapper.Map<List<VideoGame>>(Entities.Video_Games.Where(w => w.Title.Contains(title)).ToList());
        }

        public bool CheckIfGameExists(string gameTitle, string gameEdition, string gamePlatform)
        {
            if (Entities.Video_Games.Any(game => game.Title == gameTitle && game.Platform == gamePlatform && game.Edition == gameEdition))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddNewGame(Database.Video_Games videoGame)
        {
            Entities.Video_Games.Add(videoGame);
            Entities.SaveChanges();
        }
    }
}

