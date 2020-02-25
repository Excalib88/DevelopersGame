using System.Collections.Generic;
using System.Threading.Tasks;
using DevelopersGame.Web.Commands;
using Telegram.Bot;

namespace DevelopersGame.Web.Models
{
    public class Bot
    {
        private static TelegramBotClient botClient;
        private static List<TelegramCommand> commandsList;

        public static IReadOnlyList<TelegramCommand> Commands => commandsList.AsReadOnly();

        public static async Task<TelegramBotClient> GetBotClientAsync()
        {
            if (botClient != null)
            {
                return botClient;
            }

            commandsList = new List<TelegramCommand>();
            commandsList.Add(new StartCommand());
            //TODO: Add more commands

            botClient = new TelegramBotClient(AppSettings.Key);
            string hook = string.Format(AppSettings.Url, "api/message/update");
            await botClient.SetWebhookAsync(hook);
            return botClient;
        }
    }
}