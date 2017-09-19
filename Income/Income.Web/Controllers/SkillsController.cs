using Income.DataTransferObjects;
using Income.Services;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Income.Web.Controllers
{
    public class SkillsController : ApiController
    {
        ISkillsServise skillsService = null;
        public SkillsController(ISkillsServise skillsSrv)
        {
            skillsService = skillsSrv;
        }

        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, skillsService.GetAll());
        }
    }
}
