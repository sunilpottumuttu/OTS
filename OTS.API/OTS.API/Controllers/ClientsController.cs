using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OTS.DomainModel.Abstract;
using OTS.DomainModel.Entities;
using Microsoft.Extensions.Logging;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Net;
using OTS.API.Utils;
using OTS.DomainModel.Exceptions;

namespace OTS.API.Controllers
{
    [Route("api/[controller]")]
    public class ClientsController : BaseController
    {

        private readonly IClientRepository _repository;
        private readonly ILogger<ClientsController> _logger;

        public ClientsController(IClientRepository repository, ILogger<ClientsController> logger)
        {
            _repository = repository;
            _logger = logger;

        }

        // GET api/values
        
        [HttpGet]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(IEnumerable<Client>))]
        [SwaggerResponse((int)HttpStatusCode.NotFound)]
        public async Task<ActionResult> Get()
        {
            _logger.LogInformation(LoggingEvents.LIST_ITEMS, "Get Clients");
            try
            {
                var results = await this._repository.GetClients();
                if (results != null)
                {
                    return new OkObjectResult(results);
                }
                else
                {
                    return new NotFoundResult();
                }
            }
            catch (InvalidDataException ex)
            {
                return base.InvalidDataResult(ex.Message);
            }
            catch (Exception ex)
            {
                return base.ExceptionResult(ex.Message);
            }
        }

        [Route("{clientKey:int}")]
        [HttpGet()]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(Client))]
        [SwaggerResponse((int)HttpStatusCode.NotFound)]
        public async Task<ActionResult> GetById(int clientKey)
        {
            _logger.LogInformation(LoggingEvents.LIST_ITEMS, "Get Client by clientKey");
            try
            {
                var results = await this._repository.GetClientById(clientKey);
                if (results != null)
                {
                    return new OkObjectResult(results);
                }
                else
                {
                    return new NotFoundResult();
                }
            }
            catch(NoDataFoundException)
            {
                return base.NotFound();
            }
            catch (InvalidDataException ex)
            {
                return base.InvalidDataResult(ex.Message);
            }
            catch (Exception ex)
            {
                return base.ExceptionResult(ex.Message);
            }
        }

        // POST api/values
        [HttpPost]
        [SwaggerResponse((int)HttpStatusCode.Created, Type = typeof(int))]
        [SwaggerResponse((int)HttpStatusCode.BadRequest)]
        public async Task<ActionResult> Post([FromBody]Client client)
        {
            _logger.LogInformation(LoggingEvents.INSERT_ITEM, "Adds New Client");
            if (ModelState.IsValid)
            {
                try
                {
                    var recordId = await _repository.AddClient(client);
                    return CreatedAtAction(nameof(GetById),
                    new
                    {
                        clientKey = client.ClientKey
                    }, client);
                }
                catch (InvalidDataException ex)
                {
                    return base.InvalidDataResult(ex.Message);
                }
                catch (Exception ex)
                {
                    return base.ExceptionResult(ex.Message);
                }
            }
            else
            {
                _logger.LogError("BadRequest", ModelStateErrors.GetErrorList(ModelState));
                return base.InvalidModelStateResult();
            }
        }

        // PUT api/values/5
        [Route("{clientKey:int}")]
        [HttpPut()]
        [SwaggerResponse((int)HttpStatusCode.OK)]
        [SwaggerResponse((int)HttpStatusCode.NotFound)]
        [SwaggerResponse((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Put(int clientKey, [FromBody]Client client)
        {
            _logger.LogInformation(LoggingEvents.UPDATE_ITEM, "Update an Client");
            if (ModelState.IsValid)
            {
                try
                {
                    var recordId = await _repository.UpdateClient(client);
                    return base.OKResult();
                }
                catch (InvalidDataException ex)
                {
                    return base.InvalidDataResult(ex.Message);
                }
                catch (Exception ex)
                {
                    return base.ExceptionResult(ex.Message);
                }
            }
            else
            {
                _logger.LogError("BadRequest", ModelStateErrors.GetErrorList(ModelState));
                return base.InvalidModelStateResult();
            }
        }

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
