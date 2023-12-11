using System.Threading.Tasks;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace am3bot.Controllers.Commands
{
    public class SpecialtiesComand : ICommand
    {
        public TelegramBotClient Client => Bot.GetTelegramBot().Result;
        public string Name => "Спеціальності";

        public async Task Execute(Update update)
        {
            long chatId = update.Message.Chat.Id;

            await Client.SendTextMessageAsync(
            chatId,
            text: "(105) Прикладна фізика та наноматеріали, " +
                      "\n(131) Прикладна математика та інформатика, " +
                      "\n(291) Міжнародна інформація");
        }
    }
}
