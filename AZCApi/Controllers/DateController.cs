using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AZCApi
{
    public class DateController
    {
        [ApiController]
        public class AddressController : ControllerBase
        {
            [HttpGet]
            [Route("/[controller]")]
            public async Task<ActionResult<Date>> Get()
            {
                return await Task.Run(() =>
                {
                    try
                    {
                        return StatusCode(201, new DataBaseHelper().Date.ToList());
                    }
                    catch (Exception ex)
                    {
                        return StatusCode(400, ex.Message);
                    }
                });
            }

            [HttpPut]
            [Route("/[controller]")]
            public async Task<IActionResult> Put()
            {
                // if (id != OtdelKadrov.ID_Otdel)
                //   return BadRequest();

                return await Task.Run(() =>
                {

                    try
                    {
                        return StatusCode(201, new DataBaseHelper().Date.ToList());
                    }
                    catch (Exception ex)
                    {
                        return StatusCode(400, ex.Message);
                    }
                });
            }

            [HttpPost]
            [Route("/[controller]")]
            public async Task<ActionResult<Date>> Post()
            {
                return await Task.Run(() =>
                {

                    try
                    {
                        return StatusCode(201, new DataBaseHelper().Date.ToList());
                    }
                    catch (Exception ex)
                    {
                        return StatusCode(400, ex.Message);
                    }
                });
            }

            [HttpDelete]
            [Route("/[controller]")]
            public async Task<IActionResult> Delete()
            {
                return await Task.Run(() =>
                {

                    try
                    {
                        return StatusCode(201, new DataBaseHelper().Date.ToList());
                    }
                    catch (Exception ex)
                    {
                        return StatusCode(400, ex.Message);
                    }
                });
            }
        }
    }
}
