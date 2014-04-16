// <copyright file="IEncounterRepository.cs" company="CHSInc">
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
    public interface IEncounterRepository
    {
        IList<EncounterModel> GetAllEncounters(int campaignId);

        IList<EncounterModel> GetActiveEncounters(int campaignId);

        EncounterModel AddEncounter(EncounterModel encounter);

        EncounterModel UpdateEncounter(EncounterModel encounter);
    }
}
