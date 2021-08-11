using CRUD_BAL.Interface;
using CRUD_DAL.Interface;
using CRUD_DAL.Entities;

namespace CRUD_BAL.Service
{
    public class ManagerService : Service<Manager> ,IManagerService
    {
        public ManagerService(IRepository<Manager> repository) 
            : base(repository) { }
    }
}
