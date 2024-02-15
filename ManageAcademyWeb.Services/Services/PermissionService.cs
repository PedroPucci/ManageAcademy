using AutoMapper;
using ManageAcademyWeb.Domain.Contracts;
using ManageAcademyWeb.Domain.Dto;
using ManageAcademyWeb.Domain.Entity;
using ManageAcademyWeb.Repository.Repository.Interfaces;
using ManageAcademyWeb.Services.Services.Interfaces;

namespace ManageAcademyWeb.Services.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IRepositoryUoW _repositoryUoW;
        private readonly IMapper _mapper;

        public PermissionService(IRepositoryUoW repositoryUoW,
            IMapper mapper)
        {
            _repositoryUoW = repositoryUoW;
            _mapper = mapper;
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