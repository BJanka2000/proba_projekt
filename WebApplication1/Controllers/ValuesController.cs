using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Controllers
{
    [Route("index")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        //összes Rendelés lekérdezése
        [HttpGet]
        public IActionResult Get()
        {
            Models.WebshopContext context = new Models.WebshopContext();
            return Ok(context.Rendelések.ToList());
        }

        //1 rendelés lekérdezése
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            Models.WebshopContext context = new Models.WebshopContext();
            var keresettRendelés = (from x in context.Rendelések
                                where x.RendId == id
                                select x).FirstOrDefault();
            return Ok(keresettRendelés);
        }

        // rendelés törlése
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            Models.WebshopContext context = new Models.WebshopContext();
            var törlendőRendelés = (from x in context.Rendelések
                                where x.RendId == id
                                select x).FirstOrDefault();
            context.Remove(törlendőRendelés);
            context.SaveChanges();
        }

        //// új rekord felvétele
        //[HttpPost]
        //public void Post([FromBody] Models.Rendelések újRendelés)
        //{
        //    Models.WebshopContext context = new Models.WebshopContext();
        //    context.Rendelések.Add(újRendelés);
        //    context.SaveChanges();
        //}
    }
}
