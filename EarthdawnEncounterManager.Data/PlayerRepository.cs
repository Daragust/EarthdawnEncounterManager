// <copyright file="PlayerRepository.cs" company="CHSInc">
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
    public class PlayerRepository : IPlayerRepository
    {
        private static List<PlayerModel> players =
            new List<PlayerModel>()
            {
                new PlayerModel()
                {
                    Id = 1,
                    UserName = "Daragust",
                    FirstName = "Aaron",
                    LastName = "Wallestad",
                    IsGM = true
                },
                new PlayerModel()
                {
                    Id = 2,
                    UserName = "Beandon",
                    FirstName = "Brandon",
                    LastName = "Thompson",
                    IsGM = false
                }
            };

        public IList<PlayerModel> GetPlayers()
        {
            return players;
        }

        public PlayerModel GetPlayer(int id)
        {
            return players.FirstOrDefault(p => p.Id == id);
        }

        public PlayerModel GetPlayer(string userName)
        {
            return players.FirstOrDefault(p => p.UserName == userName);
        }

        public PlayerModel AddPlayer(PlayerModel player)
        {
            var newId = players.Max(p => p.Id) + 1;
            player.Id = newId;
            players.Add(player);

            return player;
        }
    }
}
