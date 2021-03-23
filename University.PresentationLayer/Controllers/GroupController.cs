using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using University.DomainLayer.Entities;

namespace University.PresentationLayer.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[Authorize]
    public class GroupController: ControllerBase
    {
        [HttpGet]
        public IEnumerable<Group> GetAll()
        {
            return new List<Group>();
        }
    }
}
