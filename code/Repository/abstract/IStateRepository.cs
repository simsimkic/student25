using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model.Users;

namespace bolnica.Repository
{
    public interface IStateRepository : IGetterRepository<State, long>, IEagerRepository<State, long>
    {

    }
}
