﻿using AutoMapper;
using ManageAcademyWeb.Domain.Dto;
using ManageAcademyWeb.Domain.Entity;
using ManageAcademyWeb.Services.Services.Interfaces;

namespace ManageAcademyWeb.Services.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IRepositoryUoW _repositoryUoW;
        private readonly IMapper _mapper;

        public UserService(IRepositoryUoW repositoryUoW,
            IMapper mapper)
        {
            _repositoryUoW = repositoryUoW;
            _mapper = mapper;
        }

        public UserService(IRepositoryUoW repositoryUoW)
        {
            _repositoryUoW = repositoryUoW;
        }

        public Task<GenericResult<PermissionEntity>> AddPermission(PermissionDto permissionDto)
        {
            throw new NotImplementedException();
        }

        public Task<PermissionEntity> UpdatePermission(PermissionDto permissionDto)
        {
            throw new NotImplementedException();
        }

        public Task<List<PermissionEntity>> GetAllPermissions()
        {
            throw new NotImplementedException();
        }
    }
}