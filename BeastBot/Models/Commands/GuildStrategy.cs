using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace BeastBot.Models.Commands
{
    class GuildStrategy : IStrategy
    {
        Task IStrategy.DoAlgorithm(Message message, TelegramBotClient client)
        {
            throw new NotImplementedException();
        }
    }
}
