using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoYouEvenLiftBro.Utility
{
    public static class ModelStateHelper
    {
        public static IEnumerable<ModelError> Errors(this ModelStateDictionary modelState)
        {
            if (!modelState.IsValid)
            {
                return modelState.Values.SelectMany(v => v.Errors);
            }
            return null;
        }
    }
}
