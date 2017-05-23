using AutoMapper;
using EdgixshuaMediaLibrary.VideoGames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdgixshuaMediaLibrary.DataLayer
{
    public class MappingConfig
    {
        public void SetupMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Database.Video_Games, VideoGame>();
                cfg.CreateMap<VideoGame, Database.Video_Games>();
            });
        }
    }
}