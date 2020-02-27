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
        public override string Name { get; } = "U+1F45C Магазин";
        public override async Task Execute(Message message, ITelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var keyBoard = new ReplyKeyboardMarkup
            {
                Keyboard = new[]
                {
                    new[]
                    {
                        new KeyboardButton("U+1F3E0 Главная")
                    },
                    new[]
                    {
                        new KeyboardButton("U+1F451 Ранк")
                    },
                    new []
                    {
                        new KeyboardButton("U+1F45C Магазин")
                    },
                    new []
                    {
                        new KeyboardButton("U+1F4D6 Помощь") 
                    }
                }
            };
            await client.SendTextMessageAsync(chatId, "Магазин",
                parseMode: ParseMode.Markdown, replyMarkup:keyBoard);
        }

        public override bool Contains(Message message)
        {
            throw new System.NotImplementedException();
        }
    }
}