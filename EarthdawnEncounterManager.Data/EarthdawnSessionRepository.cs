// <copyright file="EarthdawnSessionRepository.cs" company="CHSInc">
// © 2014 CHS Inc.
// </copyright>
// <author>AWallest</author>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Http;
using EarthdawnEncounterManager.Data.Contracts;

namespace EarthdawnEncounterManager.Data
{
    public class EarthdawnSessionRepository : IEarthdawnSessionRepository
    {
        private static List<EarthdawnSessionModel> sessions = new List<EarthdawnSessionModel>()
            {
                new EarthdawnSessionModel()
                {
                    Id = 1,
                    StartDate = DateTime.Parse("5/1/2014"),
                    EndDate = DateTime.Parse("5/1/2014"),
                    CampaignId = 1,
                    LegendPoints = 5000
                },
                new EarthdawnSessionModel()
                {
                    Id = 2,
                    StartDate = DateTime.Parse("5/8/2014"),
                    EndDate = DateTime.Parse("5/8/2014"),
                    CampaignId = 1,
                    LegendPoints = 7000
                },
                new EarthdawnSessionModel()
                {
                    Id = 3,
                    StartDate = DateTime.Parse("5/1/2014"),
                    EndDate = null,
                    CampaignId = 2,
                    LegendPoints = null
                }
            };
 

        public List<EarthdawnSessionModel> GetSessions()
        {
            return sessions;
        }

        public EarthdawnSessionModel GetSession(int sessionId)
        {
            return sessions.FirstOrDefault(x => x.Id == sessionId);
        }

        public EarthdawnSessionModel AddSession(EarthdawnSessionModel session)
        {
            int? newId = 1;
            if(sessions.Count > 0)
                newId = sessions.Max(i => i.Id);

            session.Id = newId;
            sessions.Add(session);

            return session;
        }

        public EarthdawnSessionModel UpdateSession(EarthdawnSessionModel session)
        {
            return session;
        }
    }
}
