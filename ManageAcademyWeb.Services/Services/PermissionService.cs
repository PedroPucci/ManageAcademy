using AutoMapper;
using ManageAcademyWeb.Domain.Contracts;
using ManageAcademyWeb.Domain.Dto;
using ManageAcademyWeb.Domain.Entity;
using ManageAcademyWeb.Domain.Enums;
using ManageAcademyWeb.Domain.Helpers;
using ManageAcademyWeb.Domain.Validator;
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

        public async Task<GenericResult<PermissionEntity>> AddPermission(PermissionDto permissionDto)
        {
            await CheckValidParametersPermissionsAsync(permissionDto);
            using var transaction = _repositoryUoW.BeginTransaction();
            try
            {
                var permissionEntity = _mapper.Map<PermissionDto, PermissionEntity>(permissionDto);
                var result = await _repositoryUoW.PermissionRepository.AddPermissionAsync(permissionEntity);

                await _repositoryUoW.SaveAsync();
                await transaction.CommitAsync();
                
                return GenericResult<PermissionEntity>.Ok(responseData: result);
            }
            catch (Exception)
            {
                transaction.Rollback();
                return GenericResult<PermissionEntity>.Error(ApplicationErrors.Application_Error_General.Description());
            }
            finally
            {
                transaction.Dispose();
            }
        }

        private async Task CheckValidParametersPermissionsAsync(PermissionDto permissionDto)
        {
            var permissionValidation = await new PermissionDtoValidator().ValidateAsync(permissionDto);

            if (!permissionValidation.IsValid)
            {
                GenericResult<PermissionEntity>.Error(ApplicationErrors.Application_Error_PermissaoInvalid.Description());
                throw new InvalidOperationException("Invalid Parameters!");
            }
        }

        private bool CheckExistPermission(string permissionName)
        {
            var result = _repositoryUoW.PermissionRepository.GetPermissionByNameAsync(permissionName);
            return result != null ? true : false;
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