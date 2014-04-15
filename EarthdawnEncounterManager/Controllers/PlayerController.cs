using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using EarthdawnEncounterManager.Data;
using EarthdawnEncounterManager.Data.Contracts;

namespace EarthdawnEncounterManager.Web.Controllers
{
    public class PlayerController : ApiController
    {
        private IPlayerRepository playerRepository;

        public PlayerController(IPlayerRepository playerRepository)
        {
            this.playerRepository = playerRepository;
        }

        public IHttpActionResult GetPlayer(string userName)
        {
            var result = playerRepository.GetPlayer(userName);
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }
    }
}
