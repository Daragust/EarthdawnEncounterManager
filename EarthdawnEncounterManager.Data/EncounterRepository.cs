// <copyright file="EncounterRepository.cs" company="CHSInc">
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
    public class EncounterRepository : IEncounterRepository
    {
        private static List<EncounterModel> encounters =
            new List<EncounterModel>() {
                new EncounterModel()
                {
                    Id = 1,
                    Completed = false,
                    Name = "Fight with Brigands",
                    Order = 1,
                    CampaignId = 1,
                    Enemies = new List<EncounterEnemyModel>()
                },
                new EncounterModel()
                {
                    Id = 2,
                    Completed = false,
                    Name = "Fight with Brigands",
                    Order = 2,
                    CampaignId = 1,
                    Enemies = new List<EncounterEnemyModel>()
                },
                new EncounterModel()
                {
                    Id = 3,
                    Completed = true,
                    Name = "Fight with Brigands",
                    Order = 2,
                    CampaignId = 2,
                    Enemies = new List<EncounterEnemyModel>()
                }
            };

        private IEncounterEnemyRepository encounterEnemyRepository;

        public EncounterRepository(IEncounterEnemyRepository encounterEnemyRepository)
        {
            this.encounterEnemyRepository = encounterEnemyRepository;
        }

        public IList<EncounterModel> GetAllEncounters(int campaignId)
        {
            var encounterEnemies = encounterEnemyRepository.GetEncounterEnemies();

            foreach (var encounter in encounters)
            {
                encounter.Enemies.AddRange(encounterEnemies.Where(e => e.EncounterId == encounter.Id));
            }

            return encounters;
        }

        public IList<EncounterModel> GetActiveEncounters(int campaignId)
        {
            var encountersList = encounters.Where(e => e.CampaignId == campaignId && !e.Completed).ToList();

            foreach (var encounter in encountersList)
            {
                encounter.Enemies.AddRange(encounterEnemyRepository.GetEncounterEnemies(encounter.Id));
            }

            return encountersList;
        }

        public EncounterModel AddEncounter(EncounterModel encounter)
        {
            encounter.Id = encounters.Max(e => e.Id) + 1;
            encounters.Add(encounter);

            foreach (var encounterEnemy in encounter.Enemies)
            {
                encounterEnemyRepository.AddEncounterEnemy(encounterEnemy);
            }

            return encounter;
        }

        public EncounterModel UpdateEncounter(EncounterModel encounter)
        {
            if (encounter == null)
                throw new ArgumentNullException("encounter");

            if (encounter.Id == null)
                throw new ArgumentException("The id for encounter cannot be null.");

            var oldEncounter = encounters.FirstOrDefault(e => e.Id == encounter.Id);

            if(oldEncounter == null)
                throw new ArgumentException("Cannot update encounter. No matching encounter found to update.");

            encounters.Remove(oldEncounter);
            encounters.Add(encounter);

            foreach (var encounterEnemy in encounter.Enemies)
            {
                if (encounterEnemy.IsNew)
                {
                    encounterEnemyRepository.AddEncounterEnemy(encounterEnemy);
                }
                else if (encounterEnemy.IsDirty)
                {
                    encounterEnemyRepository.UpdateEncounterEnemy(encounterEnemy);
                }
            }

            return encounter;
        }
    }
}
