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
        public static List<VideoGame> GetEntireVideoGameLibrary()
        {
            var videoGameList = new List<VideoGame>();

            Connection DatabaseConnectionClass = new Connection();

            SqlConnection dbConnection = new SqlConnection(DatabaseConnectionClass.GetDatabaseConnectionString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM Video_Games";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = dbConnection;

            dbConnection.Open();

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var game = new VideoGame();
                    game.Id = Convert.ToInt32(reader["Game_Id"]);
                    game.Title = reader["Game_Title"].ToString();
                    game.Edition = reader["Edition"].ToString();
                    game.Platform = reader["Platform"].ToString();
                    game.Year = Convert.ToInt32(reader["Year"]);

                    videoGameList.Add(game);
                }
            }

            dbConnection.Close();

            return videoGameList;
        }

        public static List<VideoGame> SearchByPlatform(string platformName)
        {
            var videoGameList = new List<VideoGame>();

            Connection DatabaseConnectionClass = new Connection();

            SqlConnection dbConnection = new SqlConnection(DatabaseConnectionClass.GetDatabaseConnectionString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM Video_Games WHERE Platform = " + "'" + platformName + "'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = dbConnection;

            dbConnection.Open();

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var game = new VideoGame();
                    game.Id = Convert.ToInt32(reader["Game_Id"]);
                    game.Title = reader["Game_Title"].ToString();
                    game.Edition = reader["Edition"].ToString();
                    game.Platform = reader["Platform"].ToString();
                    game.Year = Convert.ToInt32(reader["Year"]);

                    videoGameList.Add(game);
                }
            }

            dbConnection.Close();

            return videoGameList;
        }

        public static List<VideoGame> SearchByTitle(string title)
        {
            var videoGameList = new List<VideoGame>();

            Connection DatabaseConnectionClass = new Connection();

            SqlConnection dbConnection = new SqlConnection(DatabaseConnectionClass.GetDatabaseConnectionString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM Video_Games WHERE Game_Title LIKE " + "'%" + title + "%'";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = dbConnection;

            dbConnection.Open();

            using (reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var game = new VideoGame();
                    game.Id = Convert.ToInt32(reader["Game_Id"]);
                    game.Title = reader["Game_Title"].ToString();
                    game.Edition = reader["Edition"].ToString();
                    game.Platform = reader["Platform"].ToString();
                    game.Year = Convert.ToInt32(reader["Year"]);

                    videoGameList.Add(game);
                }
            }

            dbConnection.Close();

            return videoGameList;
        }

        public static bool AddNewGame(string gameTitle, string gameEdition, string gamePlatform, int gameYear)
        {
            var videoGameList = new List<VideoGame>();

            Connection DatabaseConnectionClass = new Connection();

            SqlConnection dbConnection = new SqlConnection(DatabaseConnectionClass.GetDatabaseConnectionString());
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "INSERT INTO dbo.Video_Games (Game_Title, Edition, Platform, Year)"
                + "VALUES ('" + gameTitle + "', '"
                + gameEdition + "', '"
                + gamePlatform + "', "
                + gameYear + ")";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = dbConnection;

            dbConnection.Open();

            int sqlTest = cmd.ExecuteNonQuery();

            dbConnection.Close();

            if (sqlTest == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool CheckGameDoesNotExist(string gameTitle, string gameEdition, string gamePlatform)
        {
            var videoGameList = new List<VideoGame>();

            Connection DatabaseConnectionClass = new Connection();

            SqlConnection dbConnection = new SqlConnection(DatabaseConnectionClass.GetDatabaseConnectionString());
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;

            cmd.CommandText = "SELECT * FROM dbo.Video_Games "
                + "WHERE Game_Title = '" + gameTitle + "'"
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
                    game.Id = Convert.ToInt32(reader["Game_Id"]);
                    game.Title = reader["Game_Title"].ToString();
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
