using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WEB_Portfolio_api.Data;
using WEB_Portfolio_api.Model;

namespace WEB_Portfolio_api.Controllers
{

    //Create a controller class for our command objects

    //Api controller attribute, gives us out of the box default behaviours
    //Route class defines how to get the resources, api endpoint within your controllers
    //this route name defines the api route to "api/commands" and [] makes the route to take in the mname of the controller class whenever it changes
    //this one "api/commands" will not change even if the class name change
    //[Route("api/commands")]
    //[ApiController]
    //Create api endpoints

    [Route("api/commands")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        private readonly ICommanderRepo _repository;

        public CommandsController(ICommanderRepo repository)
        {
            _repository = repository;
        }
        //Get api/commands
        [HttpGet]
        public ActionResult<IEnumerable<Command>> GetAppCommands()
        {
            //Use repository to get our commands
            //Create var to hold our commands
            var commandItems = _repository.GetAllCommands();
            //return ok success
            return Ok(commandItems);
        }

        //Get requst that will respond to the api/commands/{id}
        [HttpGet("{id}")]
        //Returning a single results
        //When we call this endpoint via api/command/{id}, the id will be returned from the uri
        public ActionResult<Command> GetCommandById(int id)
        {
            //contin our items coming from repository
            //pass the id from the id passed to our action results
            //the id comes from the request that we pass in via the uri, will be resolve via the uri, its the binding resources
            var CommandItem = _repository.GetCommandById(id);
            return Ok(CommandItem);
        }
    }
}
