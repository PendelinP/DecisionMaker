using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DecisionMaker.Engine;

namespace DecisionMaker.Api.Controllers
{
    public class DecisionController : ApiController
    {
        public string Get()
        {
            return new DecisionEngine().MakeDecision();
        }
    }
}
