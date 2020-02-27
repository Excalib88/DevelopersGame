using System.Collections.Generic;
using DevelopersGame.Domain.Abstractions;
using DevelopersGame.Domain.Commands;

namespace DevelopersGame.Domain.Services
{
    public class CommandService: ICommandService
    {
        private readonly List<TelegramCommand> _commands;

        public CommandService()
        {
            _commands = new List<TelegramCommand>
            {
                new StartCommand(),
                new MainCommand()
            };
        }

        public List<TelegramCommand> Get() => _commands;
    }
}