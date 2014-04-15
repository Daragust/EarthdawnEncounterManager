// <copyright file="ICampaignRepository.cs" company="CHSInc">
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
    public interface ICampaignRepository
    {
        IList<CampaignModel> GetCampaigns();

        CampaignModel GetCampaign(int campaignId);

        CampaignModel AddCampaign(CampaignModel campaign);

        CampaignModel UpdateCampaign(CampaignModel campaign);
    }
}
