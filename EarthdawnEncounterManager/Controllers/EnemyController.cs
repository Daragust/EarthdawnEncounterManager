using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EarthdawnEncounterManager.Data;
using EarthdawnEncounterManager.Data.Contracts;

namespace EarthdawnEncounterManager.Web.Controllers
{
    public class EnemyController : ApiController
    {
        private IEnemyRepository enemyRepository;

        public EnemyController(IEnemyRepository enemyRepository)
        {
            this.enemyRepository = enemyRepository;
        }

        public IEnumerable<EnemyModel> Get()
        {
            return enemyRepository.GetEnemys();
        }


        public EnemyModel Get(int id)
        {
            return enemyRepository.GetEnemy(id);
        }

      
        public void Post([FromBody]EnemyModel value)
        {
        }

        // PUT api/enemy/5
        public void Put(int id, [FromBody]EnemyModel value)
        {
        }
    }
}
