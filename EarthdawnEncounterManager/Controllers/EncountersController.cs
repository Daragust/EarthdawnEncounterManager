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
    public class EncountersController : ApiController
    {
        public IEncounterRepository encounterRepository;

        public EncountersController(IEncounterRepository encounterRepository)
        {
            this.encounterRepository = encounterRepository;
        }

        public IList<EncounterModel> Get(int campaignId)
        {
            return encounterRepository.GetAllEncounters(campaignId);
        }

    }
}
