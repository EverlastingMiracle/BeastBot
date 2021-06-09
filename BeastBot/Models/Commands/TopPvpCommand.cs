using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace BeastBot.Models.Commands
{
    class TopPvpCommand: Command
    {
        public override string Name
        {
            get
            {
                return "toppvp";
            }
        }

        public override async void Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;

            //GET REQUEST with parameter from message

            await client.SendTextMessageAsync(chatId, "pvpvpvpvvpv", replyToMessageId: messageId);
        }
    }
}
