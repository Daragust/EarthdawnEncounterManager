// <copyright file="CampaignModel.cs" company="CHSInc">
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
    public class CampaignModel
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public DateTime DateStarted { get; set; }

        public DateTime? DateEnded { get; set; }

        public int GmId { get; set; }
    }
}
