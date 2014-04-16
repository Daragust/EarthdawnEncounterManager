// <copyright file="IEncounterEnemyRepository.cs" company="CHSInc">
// © 2014 CHS Inc.
// </copyright>
// <author>AWallest</author>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthdawnEncounterManager.Data.Contracts
{
    public interface IEncounterEnemyRepository
    {
        List<EncounterEnemyModel> GetEncounterEnemies();

        List<EncounterEnemyModel> GetEncounterEnemies(int encounterId);

        EncounterEnemyModel AddEncounterEnemy(EncounterEnemyModel encounterEnemy);

        EncounterEnemyModel UpdateEncounterEnemy(EncounterEnemyModel encounterEnemy);
    }
}
