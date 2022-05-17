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
            this.bl = bl;
        }

        [HttpGet("name")]
        [ProducesResponseType(200, Type = typeof(Restaurant))]
        [ProducesResponseType(404)]
        public ActionResult<List<Restaurant>> Get(string name)
        {
            List<Restaurant> rest = new List<Restaurant>();

            var sr = bl.SearchRestaurants(name);
            if (sr.Count <= 0)
                return NotFound($"Restaurant {name} is not found in the database.");
            return Ok(sr);

        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post([FromBody] User user)
        {
            if (user == null)
                return BadRequest("Invaild user, try again with vaild values");
            dl.AddUser(user);
            return CreatedAtAction("Get", user);
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post([FromBody] Restaurant rest)
        {
            if (rest == null)
                return BadRequest("Invaild restaurant, try again with vaild values");
            dl.AddRestaurant(rest);
            return CreatedAtAction("Get", rest);
        }

        //[HttpPut]
        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public ActionResult Post([FromBody] Review review)
        //{
        //    if (review == null)
        //        return BadRequest("Invaild review, try again with vaild values");
        //    dl.AddReview(review);
        //    return CreatedAtAction("Get", review);
        //}

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
