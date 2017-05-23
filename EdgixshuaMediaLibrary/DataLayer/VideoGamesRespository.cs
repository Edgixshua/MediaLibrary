using AutoMapper;
using EdgixshuaMediaLibrary.Database;
using EdgixshuaMediaLibrary.VideoGames;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgixshuaMediaLibrary.DataLayer
{
    public class VideoGamesRespository
    {
        public MediaLibraryEntities Entities = new MediaLibraryEntities();

        public List<VideoGame> GetEntireVideoGameLibrary()
        {
            return Mapper.Map<List<VideoGame>>(Entities.Video_Games.ToList());
        }

        public List<VideoGame> SearchByPlatform(string platformName)
        {
            return Mapper.Map<List<VideoGame>>(Entities.Video_Games.Where(w => w.Platform == platformName).ToList());
        }

        public List<VideoGame> SearchByTitle(string title)
        {
            return Mapper.Map<List<VideoGame>>(Entities.Video_Games.Where(w => w.Title == title).ToList());
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

