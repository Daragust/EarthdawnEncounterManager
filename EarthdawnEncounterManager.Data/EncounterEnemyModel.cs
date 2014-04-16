// <copyright file="EncounterEnemy.cs" company="CHSInc">
// © 2014 CHS Inc.
// </copyright>
// <author>AWallest</author>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthdawnEncounterManager.Data
{
    public class EncounterEnemyModel : SessionActorBase
    {
        public int EnemyId { get; set; }
        public EnemyModel Enemy { get; set; }
        public int EncounterId { get; set; }
    }
}
