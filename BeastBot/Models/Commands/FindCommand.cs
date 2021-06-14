using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace BeastBot.Models.Commands
{
    class FindCommand : Command
    {
        public override string Name
        {
            get
            {
                return "find";
            }
        }

        private IStrategy strategy;

        public void SetStrategy(IStrategy newStrategy)
        {
            this.strategy = newStrategy;
        }


        public override async Task Execute(Message message, TelegramBotClient client)
        {
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;
            if (message.Text.Contains("guild"))
            {
                this.SetStrategy(new GuildStrategy());
                this.strategy.DoAlgorithm(message, client);
                await client.SendTextMessageAsync(chatId, "end of guild", replyToMessageId: messageId);
            }
            else if (message.Text.Contains("player"))
            {
                this.SetStrategy(new PlayerStrategy());
                await strategy.DoAlgorithm(message, client);
            }
            else 
            {
                await client.SendTextMessageAsync(chatId, "Please choose what you looking (guild or player)");
            }
        }
    }
}
