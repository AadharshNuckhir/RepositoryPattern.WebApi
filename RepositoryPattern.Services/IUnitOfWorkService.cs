using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern.Services
{
    public interface IUnitOfWorkService
    {
        void AddDeveloperAndProject();

        IEnumerable<Developer> GetPopularDevelopers(int count);
    }
}
