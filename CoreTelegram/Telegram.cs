using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace CoreTelegram
{
    //https://telegrambots.github.io/book/1/quickstart.html
    public class Telegram
    {
        public string BotToken { get; set; }
        private TelegramBotClient Bot;

        public Telegram(string _BotToken)
        {
            BotToken = _BotToken;
            Bot = new TelegramBotClient(BotToken);
        }

        public async Task ChannelMessage(string TextMessage)
        {
            try
            {
                Message Result = await Bot.SendTextMessageAsync(
                chatId: 0,
                text: TextMessage,
                disableNotification: true);

                string stoppers = "";
            }
            catch(Exception ex)
            {
                string stoppers = "";
            }
            
        }
    }
}
