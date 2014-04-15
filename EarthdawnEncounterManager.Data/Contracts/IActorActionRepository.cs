// <copyright file="IActorActionRepository.cs" company="CHSInc">
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
    public interface IActorActionRepository
    {
        IList<ActorAction> GetActorActions();

        ActorAction GetActorAction(int actorActionId);

        ActorAction AddActorAction(ActorAction action);

        ActorAction UpdatActorAction(ActorAction action);
    }
}
