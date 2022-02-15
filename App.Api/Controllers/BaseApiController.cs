﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public class BaseApiController : Controller
    {
        protected BaseApiController()
        {

        }
    }
}
