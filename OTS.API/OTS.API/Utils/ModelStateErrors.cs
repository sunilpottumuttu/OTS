using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OTS.API.Utils
{
    public class ModelStateErrors
    {
        public static List<Exception> GetErrorList(ModelStateDictionary modelState)
        {
            var errorList = modelState.Values.SelectMany(x => x.Errors).Select(x => x.Exception).ToList();
            return errorList;
        }
    }
}
