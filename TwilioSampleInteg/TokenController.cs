using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Twilio.Jwt;
using Twilio.Jwt.Client;
using Twilio.TwiML;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TwilioSampleInteg
{
    [Route("api/[controller]")]
    public class TokenController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public ActionResult Get()
        {
            // Put your Twilio API credentials here
            const string accountSid = "";
            const string authToken = "";

            // Put your Twilio Application SID here
            const string appSid = "";

            var scopes = new HashSet<IScope>
            {
                new OutgoingClientScope(appSid),
                new IncomingClientScope("ak")
            };
            var capability = new ClientCapability(accountSid, authToken, scopes: scopes);

            return Content(capability.ToJwt(), "application/jwt");
        }
    }
}
