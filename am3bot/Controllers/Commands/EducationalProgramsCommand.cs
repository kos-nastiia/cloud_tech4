using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types;
using Telegram.Bot;

namespace am3bot.Controllers.Commands
{
    public class EducationalProgramsCommand : ICommand
    {
        public TelegramBotClient Client => Bot.GetTelegramBot().Result;

        public string Name => "Освітні програми";

        public async Task Execute(Update update)
        {
            long chatId = update.Message.Chat.Id;


            await Client.SendTextMessageAsync(
                chatId,
                text: "Виберіть освітню програма",
                replyMarkup: GetEducationalProgramsInlineKeyboard());


        }


        private InlineKeyboardMarkup GetEducationalProgramsInlineKeyboard()
        {
            return new InlineKeyboardMarkup(new List<InlineKeyboardButton[]>
            {
                new InlineKeyboardButton[] { InlineKeyboardButton.WithUrl("(105) Прикладна фізика та наноматеріали", "https://lpnu.ua/pfn") },
                new InlineKeyboardButton[] { InlineKeyboardButton.WithUrl("(113) Прикладна математика та інформатика", "https://amath.lp.edu.ua/") },
                new InlineKeyboardButton[] { InlineKeyboardButton.WithUrl("(291) Міжнародна інформація", "https://old.lpnu.ua/education/majors/IMFS/6.291.00.02/8/2019/ua/part") },
            });
        }
    }
}
