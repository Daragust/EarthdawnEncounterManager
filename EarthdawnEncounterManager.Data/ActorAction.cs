// <copyright file="ActorAction.cs" company="CHSInc">
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
    public class ActorAction
    {
        public string Name { get; set; }
        public int? BaseAttribute { get; set; }
        public int Rank { get; set; }
        //Spell casting, melee weapon skills, ect
        public int UseValue { get; set; }
        //Effect, damage, ect
        public int? EffectValue { get; set; }
        public string Description { get; set; }
    }
}
