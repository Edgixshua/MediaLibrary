using AutoMapper;
using EdgixshuaMediaLibrary.Database;
using EdgixshuaMediaLibrary.VideoGames;
using System;
using System.Collections.Generic;
using System.Data;
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
            var emptyList = new List<VideoGame>();

            var videoGames = Entities.Video_Games.ToList();

            var videoGameLibary = Mapper.Map(videoGames, emptyList);

            return videoGameLibary;
        }

        public List<Database.Video_Games> SearchByPlatform(string platformName)
        {
            var videoGames = Entities.Video_Games.Where(w => w.Platform == platformName).ToList();

            return videoGames;
        }

        public List<Database.Video_Games> SearchByTitle(string title)
        {
            var videoGames = Entities.Video_Games.Where(w => w.Title == title).ToList();

            return videoGames;
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
        }

        public static bool CheckGameDoesNotExist(string gameTitle, string gameEdition, string gamePlatform)
        {
            var videoGameList = new List<VideoGame>();

            Connection DatabaseConnectionClass = new Connection();

            SqlConnection dbConnection = new SqlConnection(DatabaseConnectionClass.GetDatabaseConnectionString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM dbo.Video_Games "
                + "WHERE Title = '" + gameTitle + "'"
                + "AND Edition = '" + gameEdition + "'"
                + "AND Platform = '" + gamePlatform + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = dbConnection;

            dbConnection.Open();

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var game = new VideoGame();
                    game.Id = Convert.ToInt32(reader["Id"]);
                    game.Title = reader["Title"].ToString();
                    game.Edition = reader["Edition"].ToString();
                    game.Platform = reader["Platform"].ToString();
                    game.Year = Convert.ToInt32(reader["Year"]);

                    videoGameList.Add(game);
                }
            }

            dbConnection.Close();

            if (videoGameList.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
