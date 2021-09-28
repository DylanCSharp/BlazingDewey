using BlazingDewey.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazingDewey.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [RequireHttps]
    public class ReplaceController : ControllerBase
    {
        public ReplaceController()
        {

        }

        [Route("checkorder")]
        public ActionResult<List<GridTaskModel>> CheckOrderValues(List<GridTaskModel> gridTasks)
        {
            List<GridTaskModel> correctlyOrderedList = new(gridTasks);
            IComparer<GridTaskModel> comparer = new Sortingclass();
            correctlyOrderedList.Sort(comparer);

            if (correctlyOrderedList.SequenceEqual(gridTasks))
            {
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
