﻿using AutoMapper;

namespace ManageAcademyWeb.Repository
{
    public class Mappers : Profile
    {
        public Mappers() { }

        public MapperConfiguration Configuration()
        {
            return new MapperConfiguration(cfg =>
            {
                //cfg.CreateMap<PermissionEntity, PermissionDto>();
                //cfg.CreateMap<PermissionDto, PermissionEntity>();
            });
        }
    }
}