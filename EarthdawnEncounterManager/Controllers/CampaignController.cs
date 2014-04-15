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
    public class CampaignController : ApiController
    {
        private ICampaignRepository campaignRepository;

        public CampaignController(ICampaignRepository campaignRepository)
        {
            this.campaignRepository = campaignRepository;
        }

        // GET api/campaign
        public IEnumerable<CampaignModel> Get()
        {
            return campaignRepository.GetCampaigns();
        }

        // GET api/campaign/5
        public IHttpActionResult Get(int id)
        {
            var result = campaignRepository.GetCampaign(id);

            if (result != null)
                return Ok(result);
            else
                return NotFound(); 
        }

        // POST api/campaign
        [HttpPost]
        public IHttpActionResult Post(CampaignModel value)
        {
            try
            {
                return Ok(campaignRepository.AddCampaign(value));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //// PUT api/campaign/5
        //public IHttpActionResult Put(int id, [FromBody]CampaignModel value)
        //{
        //}
    }
}
