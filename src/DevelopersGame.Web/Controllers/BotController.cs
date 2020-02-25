using System;
using System.Threading.Tasks;
using DevelopersGame.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace DevelopersGame.Web.Controllers
{
    [ApiController]
    [Route("api/message/update")]
    public class BotController : Controller
    {
        [HttpPost]
        public async Task<OkResult> Post([FromBody]Update update)
        {
            Console.WriteLine("damir");
            if (update == null) return Ok();

            var commands = Bot.Commands;
            var message = update.Message;
            var botClient = await Bot.GetBotClientAsync();

            foreach (var command in commands)
            {
                if (command.Contains(message))
                {
                    await command.Execute(message, botClient);
                    break;
                }
            }
            return Ok();
        }

        [HttpGet("get")]
        public IActionResult Get()
        {
            return Ok("Bot is running...");
        }
    }
}