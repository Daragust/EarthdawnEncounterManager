// <copyright file="ActorBaseModel.cs" company="CHSInc">
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
    public abstract class ActorBaseModel : EditableItemBase
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Circle { get; set; }

        public int Toughness { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Charisma { get; set; }
        public int Perception { get; set; }
        public int Willpower { get; set; }

        public int Initiative { get; set; }

        public int PhysicalDefense { get; set; }
        public int SocialDefense { get; set; }
        public int SpellDefense { get; set; }

        public int PhysicalArmor { get; set; }
        public int MysticArmor { get; set; }

        public int? UnconsciousnessRating { get; set; }
        public int DeathRating { get; set; }
        public int WoundThreshold { get; set; }
    }
}
