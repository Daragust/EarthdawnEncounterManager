// <copyright file="SessionActorBase.cs" company="CHSInc">
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
    public class SessionActorBase : EditableItemBase
    {
        public int Id { get; set; }
        public int CurrentDamage { get; set; }
        public int Wounds { get; set; }

        public int PhysicalDefenseModifier { get; set; }
        public int SocialDefenseModifier { get; set; }
        public int SpellDefenseModifier { get; set; }

        public int PhysicalArmorModifier { get; set; }
        public int MysticArmorModifier { get; set; }

        public int ActionsModifier { get; set; }
        public int DamageModifier { get; set; }
        public int InitiativeModifier { get; set; }
    }
}
