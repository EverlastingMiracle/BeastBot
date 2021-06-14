using BeastBot.Models.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace BeastBot.Models
{
    public static class Bot
    {
        private static List<Command> commandsList;
        private static TelegramBotClient client;
        private static IReadOnlyList<Command> Commands => commandsList.AsReadOnly();

        public static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {

            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                var commands = Commands;
                var message = e.Message;
                var cclient = client; 

                foreach (var command in commands)
                {
                    if (command.Contains(message.Text))
                    {
                        command.Execute(message, cclient);
                        break;
                    }
                }
                
            }

        }

        public async static Task<TelegramBotClient> Get()
        {
            if (client != null)
            {
                return client;
            }

            client = new TelegramBotClient("1762454758:AAGxm4WnNgJXpkkKCamjSf0Ecix4UFD4QiQ");


            commandsList = new List<Command>();
            commandsList.Add(new FindCommand());
            commandsList.Add(new TopPvpCommand());
            commandsList.Add(new EventCommand());

            return client;

        }
    }
}
