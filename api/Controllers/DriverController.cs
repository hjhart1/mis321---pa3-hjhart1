using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using api.Models;
using MySql.Data;

namespace api.Controllers
{
    public class DriverController
    {
        [Route("api/[controller]")]
        [ApiController]
        public class DriverController : ControllerBase
        {
            //GET api/Driver

            [HttpGet]
            public Enumerable<Driver> Get(){
                Driver myDriver = new Driver();
                List<Driver> DriverList = new List<Driver>(){myDriver};
                return DriverList;
            }
            [HttpDelete("{id}")]
            public void Delete(int id){
                
            }

            // POST 
            [HttpPost]
            public void Post ([FromBody] string value){

            }

            // PUT
            // [HttpPut("{id}")]

        }
    }
}