using System.Collections.Generic;
using DevelopersGame.Web.Commands;

namespace DevelopersGame.Web.Services
{
    public interface ICommandService
    {
        List<TelegramCommand> Get();
    }
}