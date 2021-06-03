using Lohotron.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lohotron.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class lohi : ControllerBase
    {
        private ILohManager _lohManager;

        public lohi(ILohManager loh)
        {
            _lohManager = loh;
        }

        [HttpGet]
        public JsonResult Get()
        {
            List<LOH> table = _lohManager.Get();
            return new JsonResult(table);
        }

        [HttpPost]
        public JsonResult Post(LOH loh)
        {
            _lohManager.Create(loh);
            return new JsonResult("Вы учавствуете в лотерее");
        }

    }
}
