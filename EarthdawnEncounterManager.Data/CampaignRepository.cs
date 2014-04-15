// <copyright file="CampaignRepository.cs" company="CHSInc">
// © 2014 CHS Inc.
// </copyright>
// <author>AWallest</author>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EarthdawnEncounterManager.Data.Contracts;

namespace EarthdawnEncounterManager.Data
{
    public class CampaignRepository : ICampaignRepository
    {
        private List<CampaignModel> campaigns =
            new List<CampaignModel>()
            {
                new CampaignModel()
                {
                    Id = 1,
                    Name = "Barsave Gets Rocked",
                    DateStarted = DateTime.Parse("1/12/2014"),
                    GmId = 1
                },
                new CampaignModel()
                {
                    Id = 2,
                    Name = "Bloodwood Crazy",
                    DateStarted = DateTime.Parse("10/15/2013"),
                    GmId = 2
                },
                new CampaignModel()
                {
                    Id = 3,
                    Name = "Darind's Heroics",
                    DateStarted = DateTime.Parse("6/12/2011"),
                    DateEnded = DateTime.Parse("12/1/2012"),
                    GmId = 1
                },
                new CampaignModel()
                {
                    Id = 4,
                    Name = "Adria is a Boss!",
                    DateStarted = DateTime.Parse("1/5/2013"),
                    DateEnded = DateTime.Parse("11/20/2013"),
                    GmId = 1
                }
            };

        public IList<CampaignModel> GetCampaigns()
        {
            return campaigns;
        }

        public CampaignModel GetCampaign(int campaignId)
        {
            return campaigns.FirstOrDefault(c => c.Id == campaignId);
        }

        public CampaignModel AddCampaign(CampaignModel campaign)
        {
            var id = campaigns.Max(c => c.Id);
            campaign.Id = id + 1;
            campaigns.Add(campaign);

            return campaign;
        }

        public CampaignModel UpdateCampaign(CampaignModel campaign)
        {
            if (campaign == null || campaign.Id == null)
            {
                throw new ArgumentNullException("campaign");
            }

            var oldCampaign = campaigns.FirstOrDefault(c => c.Id == campaign.Id);

            if (oldCampaign == null)
                throw new ArgumentException("The campaign provided does not exist on the database.");

            oldCampaign.Name = campaign.Name;
            oldCampaign.DateStarted = campaign.DateStarted;
            oldCampaign.DateEnded = campaign.DateEnded;

            return oldCampaign;
        }
    }
}
