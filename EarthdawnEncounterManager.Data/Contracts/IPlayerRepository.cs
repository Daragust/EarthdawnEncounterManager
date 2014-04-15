// <copyright file="IPlayerRepository.cs" company="CHSInc">
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
    public interface IPlayerRepository
    {
        IList<PlayerModel> GetPlayers();

        PlayerModel GetPlayer(int id);

        PlayerModel GetPlayer(string userName);

        PlayerModel AddPlayer(PlayerModel player);
    }
}
