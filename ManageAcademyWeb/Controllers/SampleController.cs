using ManageAcademyWeb.Repository.Repository.Interfaces;

namespace ManageAcademyWeb.Controllers
{
    public class SampleController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRepository<string> _repository;

        public SampleController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _repository = _unitOfWork.GetRepository<string>();
        }

        public void CreateString(string a)
        {
            _repository.Add(a);
            _unitOfWork.Commit();
        }
    }
}