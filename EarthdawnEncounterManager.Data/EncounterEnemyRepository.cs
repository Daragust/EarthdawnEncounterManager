// <copyright file="EncounterEnemyRepository.cs" company="CHSInc">
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
    public class EncounterEnemyRepository : IEncounterEnemyRepository
    {
        private static List<EncounterEnemyModel> encounterEnemies =
            new List<EncounterEnemyModel>()
            {
                new EncounterEnemyModel() {
                    EnemyId = 1,
                    Id = 1,
                    EncounterId = 1
                },
                new EncounterEnemyModel() {
                    EnemyId = 1,
                    Id = 2,
                    EncounterId = 1
                },
                new EncounterEnemyModel() {
                    EnemyId = 1,
                    Id = 3,
                    EncounterId = 1
                },
                new EncounterEnemyModel() {
                    EnemyId = 2,
                    Id = 4,
                    EncounterId = 1
                },
                new EncounterEnemyModel() {
                    EnemyId = 1,
                    Id = 5,
                    EncounterId = 2
                },
                new EncounterEnemyModel() {
                    EnemyId = 2,
                    Id = 6,
                    EncounterId = 2
                },
                new EncounterEnemyModel() {
                    EnemyId = 2,
                    Id = 7,
                    EncounterId = 2
                },
                new EncounterEnemyModel() {
                    EnemyId = 1,
                    Id = 8,
                    EncounterId = 3
                },
                new EncounterEnemyModel() {
                    EnemyId = 2,
                    Id = 9,
                    EncounterId = 3
                }
            };

        private IEnemyRepository enemyRepository;

        public EncounterEnemyRepository(IEnemyRepository enemyRepository)
        {
            this.enemyRepository = enemyRepository;
        }

        public List<EncounterEnemyModel> GetEncounterEnemies()
        {
            var enemies = enemyRepository.GetEnemys();

            foreach(var enemy in encounterEnemies)
            {
                enemy.Enemy = enemies.FirstOrDefault(e => e.Id == enemy.EnemyId);
            }

            return encounterEnemies;
        }

        public List<EncounterEnemyModel> GetEncounterEnemies(int encounterId)
        {
            var enemies = enemyRepository.GetEnemys();
            var encounter = encounterEnemies.Where(e => e.EncounterId == encounterId).ToList();

            foreach(var enemy in encounter)
            {
                enemy.Enemy = enemies.FirstOrDefault(e => e.Id == enemy.EnemyId);
            }

            return encounter;
        }

        public EncounterEnemyModel AddEncounterEnemy(EncounterEnemyModel encounterEnemy)
        {
            encounterEnemy.Id = encounterEnemies.Max(e => e.Id) + 1;
            encounterEnemies.Add(encounterEnemy);

            return encounterEnemy;
        }

        public EncounterEnemyModel UpdateEncounterEnemy(EncounterEnemyModel encounterEnemy)
        {
            if (encounterEnemy == null)
                throw new ArgumentNullException("encounterEnemy");

            if (encounterEnemy.Id == null)
                throw new ArgumentException("The id for encounterEnemy cannot be null.");

            var oldEncounterEnemy = encounterEnemies.FirstOrDefault(e => e.Id == encounterEnemy.Id);

            if (oldEncounterEnemy == null)
                throw new ArgumentException("Cannot update encounterEnemy. No matching encounterEnemy found to update.");

            encounterEnemies.Remove(oldEncounterEnemy);
            encounterEnemies.Add(encounterEnemy);

            return encounterEnemy;
        }
    }
}
