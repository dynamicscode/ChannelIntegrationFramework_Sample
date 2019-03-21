using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Twilio.TwiML;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TwilioSampleInteg
{
    [Route("api/[controller]")]
    public class VoiceController : Controller
    {


        [HttpPost]
        public ActionResult Index()
        {
            var response = new VoiceResponse();
            response.Say("Thanks for calling!");

            return Content(response.ToString(), "text/xml");
        }
    }
}
