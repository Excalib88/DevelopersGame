using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace DevelopersGame.Web.Commands
{
    public class StartCommand : TelegramCommand
    {
        public override string Name => @"/start";

        public override bool Contains(Message message)
        {
            if (message.Type != MessageType.Text)
                return false;

            return message.Text.Contains(Name);
        }

        public override async Task Execute(Message message, TelegramBotClient botClient)
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
            await botClient.SendTextMessageAsync(chatId, "Привет! Тебе присвоено звание Intern! Чтоб достичь больших " +
                                                         "успехов, тебе необходимо накопить определенное количество монет(К-от слова контрибуций)! Дерзай!",
                parseMode: ParseMode.Markdown, replyMarkup:keyBoard);
        }
    }
}