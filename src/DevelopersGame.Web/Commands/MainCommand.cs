using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace DevelopersGame.Web.Commands
{
    public class MainCommand: TelegramCommand
    {
        public override string Name { get; } = "Главная";
        public override async Task Execute(Message message, ITelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var keyBoard = new InlineKeyboardMarkup(new[]
            {
                new InlineKeyboardButton
                {
                    Text = "Главная"
                },
                new InlineKeyboardButton
                {
                    Text = "Звание"
                },
            });
            await client.SendTextMessageAsync(chatId, "Главная страница!",
                parseMode: ParseMode.Markdown, replyMarkup:keyBoard);
        }

        public override bool Contains(Message message)
        {
            if (message.Type != MessageType.Text)
                return false;

            return message.Text.Contains(Name);
        }
    }
}