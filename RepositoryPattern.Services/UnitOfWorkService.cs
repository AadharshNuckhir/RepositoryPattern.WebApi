using Domain;
using Domain.Interfaces;

namespace RepositoryPattern.Services
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UnitOfWorkService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddDeveloperAndProject()
        {
            var developer = new Developer
            {
                Followers = 35,
                Name = "Mukesh Murugan"
            };
            var project = new Project
            {
                Name = "codewithmukesh"
            };
            _unitOfWork.Developers.Add(developer);
            _unitOfWork.Projects.Add(project);
            _unitOfWork.Complete();
        }

        public IEnumerable<Developer> GetPopularDevelopers(int count)
        {
            return _unitOfWork.Developers.GetPopularDevelopers(count);
        }
    }
}