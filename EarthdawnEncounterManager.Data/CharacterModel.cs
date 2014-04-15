// <copyright file="CharacterModel.cs" company="CHSInc">
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
    public class CharacterModel : ActorBaseModel
    {
        public int PlayerId { get; set; }
        public int CampaignId { get; set; }

        public int CurrentLegendPoints { get; set; }
        public int TotalLegendPoints { get; set; }
    }
}
