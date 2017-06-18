using AutoMapper;
using EdgixshuaMediaLibrary.Database;
using EdgixshuaMediaLibrary.VideoGames;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace EdgixshuaMediaLibrary.DataLayer
{
    public class VideoGamesRespository
    {
        public VideoGamesRespository(MediaLibraryEntities entities)
        {
            Entities = entities;
        }

        public MediaLibraryEntities Entities;
        
        public VideoGamesRespository()
        {
            Entities = new MediaLibraryEntities();
        }

        private List<VideoGame> MapVideoGames(object value)
        {
            return Mapper.Map<List<VideoGame>>(value);
        }

        public List<VideoGame> GetEntireVideoGameLibrary()
        {
            return MapVideoGames(Entities.Video_Games.ToList());
        }

        public List<VideoGame> SearchByPlatform(string platformName)
        {
            return MapVideoGames(Entities.Video_Games.Where(w => w.Platform == platformName).ToList());
        }

        public List<VideoGame> SearchByTitle(string title)
        {
            return MapVideoGames(Entities.Video_Games.Where(w => w.Title.Contains(title)).ToList());
        }

        public bool CheckIfGameExists(string gameTitle, string gameEdition, string gamePlatform)
        {
            if (!(Entities.Video_Games.Any(game => game.Title == gameTitle && game.Platform == gamePlatform && game.Edition == gameEdition)))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AddNewGame(string gameTitle, string gameEdition, string gamePlatform, int gameYear)
        {
            Database.Video_Games videoGame = new Database.Video_Games
            {
                Title = gameTitle,
                Edition = gameEdition,
                Platform = gamePlatform,
                Year = gameYear
            };

            Entities.Video_Games.Add(videoGame);
            Entities.SaveChanges();
        }
    }
}

