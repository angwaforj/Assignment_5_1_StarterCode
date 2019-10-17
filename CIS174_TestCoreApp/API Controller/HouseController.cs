using System.Collections.Generic;
using System.Linq;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CIS174_TestCoreApp.API_Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseController : ControllerBase
    {
       public IEnumerable<HouseViewModel> house = new List<HouseViewModel>()
        {
           new HouseViewModel()
           {
               Id = 1,
               BedRooms = 4,
               SquareFeet = 1854,
               DateBuilt = "05/28/1973",
               Flooring = "Carpet"
           },
           new HouseViewModel()
           {
               Id = 2,
               BedRooms = 3,
               SquareFeet = 1675,
               DateBuilt = "10/17/2015",
               Flooring = "Hardwood"
           }
        };
        // GET: api/House
        [HttpGet]
        public IEnumerable<HouseViewModel> Get()
        {
           

            return house;

        }

        // GET: api/House/5
        [HttpGet("{id}", Name = "Get")]
        public IEnumerable<HouseViewModel> Get(int id)
        {

            return house.Where(x => x.Id == id);
        }

        // POST: api/House
        [HttpPost]
        public void Post(HouseViewModel val)
        {
            house.Append(val);
        }

       
        
    }
}
