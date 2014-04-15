// <copyright file="EnemyModel.cs" company="CHSInc">
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
    public class EnemyModel : ActorBaseModel
    {
        public int Actions { get; set; }
        public List<ActorAction> Abilities { get; set; }

        public int LegendReward { get; set; }
        public string Difficulty { get; set; }
    }
}
