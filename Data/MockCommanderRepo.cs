using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEB_Portfolio_api.Model;

namespace WEB_Portfolio_api.Data
{

    //Create new values 
    //MockReposity with data that not going anywhere
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, Howto = "Run Asp.Net in Docker", Line = "Runtime", Platform = "Asp.Net"},
                new Command { Id = 2, Howto = "Deploy Web App in App service", Line = "Runtime", Platform = "Azure"},
                new Command { Id = 3, Howto = "Azure service registryr", Line = "Runtime", Platform = "Azure ASR" }
            }; //;terminates actions

            return commands;
        }
        //Get it to return these values using the command model{Object values}
        //When we call this method, its not going to look up yet, its just going to return these values
        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, Howto = "Run Asp.Net in Docker", Line = "Runtime", Platform = "Asp.Net" };
        }
    }
}
