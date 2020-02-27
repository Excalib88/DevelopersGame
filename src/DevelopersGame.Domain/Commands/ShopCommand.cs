using System.Threading.Tasks;
using DevelopersGame.Domain.Abstractions;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace DevelopersGame.Domain.Commands
{
    public class ShopCommand: TelegramCommand
    {
        public override string Name { get; } = "\U0001F45C Магазин";
        public override async Task Execute(Message message, ITelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var keyBoard = new ReplyKeyboardMarkup
            {
                Keyboard = new[]
                {
                    new[]
                    {
                        new KeyboardButton("\U0001F3E0 Главная")
                    },
                    new[]
                    {
                        new KeyboardButton("\U0001F451 Ранк")
                    },
                    new []
                    {
                        new KeyboardButton("\U0001F45C Магазин")
                    },
                    new []
                    {
                        new KeyboardButton("\U0001F4D6 Помощь") 
                    }
                }
            };
            await client.SendTextMessageAsync(chatId, "Магазин",
                parseMode: ParseMode.Html, replyMarkup:keyBoard);
        }

        public override bool Contains(Message message)
        {
            throw new System.NotImplementedException();
        }
    }
}