using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zouave.Domain;
using Zouave.Domain.Users;

namespace Zouave.Data.Repository.Users
{
    public partial class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
