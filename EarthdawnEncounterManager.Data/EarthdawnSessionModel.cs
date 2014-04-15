// <copyright file="EarthdawnSession.cs" company="CHSInc">
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
    public class EarthdawnSessionModel
    {
        public int? Id { get; set; }
        public int CampaignId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? LegendPoints { get; set; }
    }
}
