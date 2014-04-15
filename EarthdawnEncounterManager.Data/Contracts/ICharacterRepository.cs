// <copyright file="ICharacterRepository.cs" company="CHSInc">
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
    public interface ICharacterRepository
    {
        IList<CharacterModel> GetCharacters(int campaignId);

        IList<CharacterModel> GetPlayerCharacters(int playerId);

        CharacterModel AddCharacter(CharacterModel character);

        CharacterModel UpdateCharacter(CharacterModel character);
    }
}
