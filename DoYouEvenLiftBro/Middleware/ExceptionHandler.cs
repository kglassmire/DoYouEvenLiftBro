using DoYouEvenLiftBro.Responses;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DoYouEvenLiftBro.Middleware
{
    public class ExceptionHandler
    {

        private readonly RequestDelegate _next;
        private static JsonSerializerSettings _jsonSettings;

        public ExceptionHandler(RequestDelegate next)
        {
            _next = next;
            ConfigureJsonSerializerSettings();

        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private void ConfigureJsonSerializerSettings()
        {
            _jsonSettings = new JsonSerializerSettings();
            var contractResolver = new CamelCasePropertyNamesContractResolver();
            // turns out there are self-reference loops on these objects frequently. Looks like I am going to have to deal with a lack of camel casing.
            //contractResolver.IgnoreSerializableInterface = false;
            //contractResolver.IgnoreSerializableAttribute = false;
            _jsonSettings.ContractResolver = contractResolver;
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var response = context.Response;
            response.ContentType = "application/json";
            response.StatusCode = (int)HttpStatusCode.InternalServerError;

            Log.Error(exception, "An unexpected server error occurred");
            String json = String.Empty;
            try
            {
                json = JsonConvert.SerializeObject(new FiveHundredResponse()
                {
                    Data = exception,
                    Message = "An unexpected server error occurred",
                    Status = "error"
                }, _jsonSettings);
            }
            catch (Exception e)
            {
                Log.Error(e, "Error while attempting to serialize 500 exception for response. Returning blank instead.");
            }
            finally
            {
                await response.WriteAsync(json);
            }
        }
    }
}
