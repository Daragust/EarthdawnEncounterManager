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
        IList<EncounterModel> GetAllEncounters(int CampaignId);

        IList<EncounterModel> GetActiveEncounters(int CampaignId);

        EncounterModel AddEncounter(EncounterModel encounter);

        EncounterModel UpdateEncounter(EncounterModel encounter);
    }
}
