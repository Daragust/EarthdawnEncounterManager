// <copyright file="EnemyRepository.cs" company="CHSInc">
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
    public class EnemyRepository : IEnemyRepository
    {
        private static List<EnemyModel> enemies =
            new List<EnemyModel>()
            {
                new EnemyModel()
                {
                    Abilities = new List<ActorAction>(),
                    Charisma = 12,
                    Dexterity = 15,
                    Strength = 11,
                    Toughness = 18,
                    Perception = 8,
                    Willpower = 10,
                    Actions = 4,
                    DeathRating = 66,
                    Id = 1,
                    Initiative = 6,
                    MysticArmor = 2,
                    Name = "First Test Creature",
                    PhysicalArmor = 10,
                    PhysicalDefense = 8,
                    SocialDefense = 17,
                    SpellDefense = 10,
                    UnconsciousnessRating = 55,
                    WoundThreshold = 10,
                    Circle = 4,
                    LegendReward = 1000,
                    Difficulty = "One per 2 players."
                },
                new EnemyModel()
                {
                    Abilities = new List<ActorAction>(),
                    Charisma = 8,
                    Dexterity = 12,
                    Strength = 19,
                    Toughness = 9,
                    Perception = 14,
                    Willpower = 16,
                    Actions = 2,
                    DeathRating = 166,
                    Id = 2,
                    Initiative = 8,
                    MysticArmor = 12,
                    Name = "Second Test Creature",
                    PhysicalArmor = 5,
                    PhysicalDefense = 16,
                    SocialDefense = 4,
                    SpellDefense = 9,
                    UnconsciousnessRating = 135,
                    WoundThreshold = 5,
                    Circle = 6,
                    LegendReward = 2500,
                    Difficulty = "Group"
                }
            };

        public IList<EnemyModel> GetEnemys()
        {
            return enemies;
        }

        public EnemyModel GetEnemy(int enemyId)
        {
            return enemies.FirstOrDefault(e => e.Id == enemyId);
        }

        public EnemyModel AddEnemy(EnemyModel enemy)
        {
            enemy.Id = enemies.Max(e => e.Id) + 1;
            enemies.Add(enemy);
            enemy.IsNew = false;
            enemy.IsDirty = false;

            return enemy;
        }

        public EnemyModel UpdateEnemy(EnemyModel enemy)
        {
            var oldEnemy = enemies.FirstOrDefault(e => e.Id == enemy.Id);

            if (oldEnemy == null)
            {
                throw new ArgumentException("enemy cannot be updated because does not exist");
            }
            
            enemies.Remove(oldEnemy);
            enemies.Add(enemy);
            enemy.IsNew = false;
            enemy.IsDirty = false;

            return enemy;
        }
    }
}
