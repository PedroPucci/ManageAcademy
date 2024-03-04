using AutoMapper;
using ManageAcademyWeb.Repository.Repository.Interfaces;
using ManageAcademyWeb.Services.Services.Interfaces;
using Microsoft.Extensions.Configuration;

namespace ManageAcademyWeb.Services.Services
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        private readonly IRepositoryUoW _repositoryUoW;
        private readonly IMapper _mapper;
        private readonly IConfiguration _config;
        
        public UnitOfWorkService(IRepositoryUoW repositoryUoW, IMapper mapper, IConfiguration config)
        {
            _repositoryUoW = repositoryUoW;
            _mapper = mapper;
            _config = config;
        }
    }
}