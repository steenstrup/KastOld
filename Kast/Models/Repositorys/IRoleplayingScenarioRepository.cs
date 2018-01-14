using System.Collections.Generic;

namespace Kast.Models.Repositorys
{
    public interface IRoleplayingScenarioRepository
    {
        IEnumerable<RoleplayingScenario> RoleplayingScenarios { get; }

        RoleplayingScenario GetRoleplayingScenarioById(int GetRoleplayingScenarioId);
    }
}
