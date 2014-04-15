// <copyright file="IEarthdawnSessionRepository.cs" company="CHSInc">
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
    public interface IEarthdawnSessionRepository
    {
        List<EarthdawnSessionModel> GetSessions();

        EarthdawnSessionModel GetSession(int sessionId);

        EarthdawnSessionModel AddSession(EarthdawnSessionModel session);

        EarthdawnSessionModel UpdateSession(EarthdawnSessionModel session);
    }
}
