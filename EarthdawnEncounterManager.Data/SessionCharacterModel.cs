// <copyright file="SessionCharacter.cs" company="CHSInc">
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
    public class SessionCharacterModel : SessionActorBase
    {
        public int CharacterId { get; set; }
        public CharacterModel Character { get; set; }
    }
}
