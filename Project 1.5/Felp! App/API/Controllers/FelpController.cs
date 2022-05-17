using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using BL;
using DL;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Caching.Memory;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FelpController : ControllerBase
    {
        private ISQLRepo dl;
        private ILogic bl;
        private IMemoryCache memoryCache;
        private string stringname;

        public FelpController(ISQLRepo dl, ILogic bl, IMemoryCache memoryCache)
        {
            this.dl = dl;
            this.memoryCache = memoryCache;
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<Restaurant>))]
        public ActionResult<List<Restaurant>> Get()
        {
            List<Restaurant> rest = new List<Restaurant>();
            try
            {
                if(!memoryCache.TryGetValue("restList", out rest))
                {
                    rest = bl.SearchRestaurants(stringname);
                    memoryCache.Set("restList", rest, new TimeSpan(0, 1, 0));
                }
            }
            catch (SqlException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return Ok(rest);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post([FromBody] User user)
        {
            if (user == null)
                return BadRequest("Invaild user, try again with vaild values");
            //dl.AddUser(user);
            return CreatedAtAction("Get", user);
        }

        //[HttpGet]
        //public List<Restaurant> Get()
        //{
        //    return rest;
        //}

        //public Restaurant Get(string name)
        //{
        //    //filterrest.Find(x => x.Name.Contains(name));
        //}
    }

}
