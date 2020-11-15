using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_Portfolio_api.Model;

namespace WEB_Portfolio_api.Data
{

    //Method signatures our consumers are going to use, and well get into the implementation later
    //Its a contract, list of method signature
    //Building a rest api going to create, read, update and delete/ repository design
    public interface ICommanderRepo
    {

        //These are methods specified in the interface
        //Give me a list of all our command resources
        //Dont implement, just defining the operation and methods available using this interface
        IEnumerable<Command> GetAllCommands();

        //Return a single command back to the user based on the Id they enter

        Command GetCommandById(int id);

    }
}
