using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace OTS.API.Controllers
{
    public class BaseController:Controller
    {
        protected virtual ContentResult InvalidDataResult(string msg)
        {
            return new ContentResult() { StatusCode = (int?)HttpStatusCode.NotFound, Content = msg };
        }
        protected virtual ContentResult ExceptionResult(string msg)
        {
            return new ContentResult() { StatusCode = (int?)HttpStatusCode.BadRequest, Content = msg };
        }
        protected virtual ContentResult InvalidModelStateResult()
        {
            return new ContentResult() { StatusCode = (int?)HttpStatusCode.BadRequest, Content = "Invalid Model State" };
        }
        protected virtual OkResult OKResult()
        { return new OkResult(); }

    }
}
