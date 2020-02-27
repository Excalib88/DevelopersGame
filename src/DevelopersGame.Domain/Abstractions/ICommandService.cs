using System.Collections.Generic;

namespace DevelopersGame.Domain.Abstractions
{
    public interface ICommandService
    {
        List<TelegramCommand> Get();
    }
}