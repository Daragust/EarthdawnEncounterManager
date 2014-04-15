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
    public class SessionController : ApiController
    {
        private IEarthdawnSessionRepository earthdawnSessionRepository;

        public SessionController(IEarthdawnSessionRepository earthdawnSessionRepository)
        {
            this.earthdawnSessionRepository = earthdawnSessionRepository;
        }

        [HttpGet]
        public IList<EarthdawnSessionModel> Get()
        {
            return earthdawnSessionRepository.GetSessions().OrderBy(x => x.StartDate).ThenBy(x => x.EndDate).ToList();
        }

        [HttpGet]
        public IHttpActionResult GetSession(int sessionId)
        {
            var result = earthdawnSessionRepository.GetSession(sessionId);

            if (result != null)
                return Ok(result);
            else
                return NotFound();
        }

        [HttpPost]
        public IHttpActionResult Post(EarthdawnSessionModel model)
        {
            try
            {
                return Ok(earthdawnSessionRepository.AddSession(model));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
