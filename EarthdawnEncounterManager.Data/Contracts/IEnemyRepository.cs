// <copyright file="IEnemyRepository.cs" company="CHSInc">
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
    public interface IEnemyRepository
    {
        IList<EnemyModel> GetEnemys();

        EnemyModel GetEnemy(int enemyId);

        EnemyModel AddEnemy(EnemyModel enemy);

        EnemyModel UpdateEnemy(EnemyModel enemy);
    }
}
