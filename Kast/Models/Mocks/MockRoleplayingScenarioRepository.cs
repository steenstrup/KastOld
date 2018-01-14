using System;
using System.Collections.Generic;
using Kast.Models.Repositorys;

namespace Kast.Models.Mocks
{
    public class MockRoleplayingScenarioRepository : IRoleplayingScenarioRepository
    {
        public IEnumerable<RoleplayingScenario> RoleplayingScenarios
        {
            get
            {
                return new List<RoleplayingScenario>
                {
                    new RoleplayingScenario{ }
                };
            }
        }

        public RoleplayingScenario GetRoleplayingScenarioById(int roleplayingScenarioId)
        {
            throw new NotImplementedException();
        }
    }
}
