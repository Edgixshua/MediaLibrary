﻿using AutoMapper;
using EdgixshuaMediaLibrary.VideoGames;

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