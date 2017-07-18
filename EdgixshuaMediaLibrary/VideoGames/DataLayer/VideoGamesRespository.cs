using AutoMapper;
using EdgixshuaMediaLibrary.VideoGames.Database;
using EdgixshuaMediaLibrary.VideoGames;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EdgixshuaMediaLibrary.VideoGames.DataLayer;

namespace EdgixshuaMediaLibrary.DataLayer
{
    public class VideoGamesRespository : IVideoGamesRepository
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
            => Mapper.Map<List<VideoGame>>(value);

        public List<VideoGame> ReturnAll()
            => MapVideoGames(Entities.Video_Games.ToList());
        
        public List<VideoGame> PlatformSearch(string platformName)
            => MapVideoGames(Entities.Video_Games.Where(w => w.Platform == platformName).ToList());

        public List<VideoGame> TitleSearch(string title)
            => MapVideoGames(Entities.Video_Games.Where(w => w.Title.Contains(title)).ToList());
        
        public bool IfExists(string gameTitle, string gameEdition, string gamePlatform)
            => (!(Entities.Video_Games.Any(game => game.Title == gameTitle && game.Platform == gamePlatform && game.Edition == gameEdition)));

        public void Add(string gameTitle, string gameEdition, string gamePlatform, int gameYear)
        {
            VideoGames.Database.Video_Games videoGame = new VideoGames.Database.Video_Games
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

