using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace BeastBot.Models.Commands
{
    class EventCommand : Command
    {
        public override string Name 
        {
            get
            {
                return "killboard";
            }
        }
        // FROM PLAYER GET PLAYERID AND CHECK LAST EVENT ID IF NOT EQUALS SHOW MESSAGE WITH EVENT check every 5 min (thread.sleep? or Task.Delay()?)
        public override async Task Execute(Message message, TelegramBotClient client)
        {
            HttpClient httpClient = new HttpClient();
            var chatId = message.Chat.Id;
            var messageId = message.MessageId;
            
                string rootUri = "https://gameinfo.albiononline.com/api/gameinfo/search?q=";
                string playerName = message.Text.Replace("killboard", "").Trim(' ');
                string requestString = rootUri + playerName;
                var request = new HttpRequestMessage(HttpMethod.Get, requestString);
                

            var Events = await GetTenEventsAsync(playerId, httpClient);

                await client.SendTextMessageAsync(chatId, "Killboard was enabled", replyToMessageId: messageId);
            
        }

        public async Task<EventModel> GetTenEventsAsync(String playerId, HttpClient httpClient) 
        {
            EventModel data = null;
            string rootUri = "https://gameinfo.albiononline.com/api/gameinfo/players/";
            string requestString = rootUri + playerId+"/deaths";
            var request = new HttpRequestMessage(HttpMethod.Get, requestString);
            HttpResponseMessage response = await httpClient.SendAsync(request);
            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadFromJsonAsync<EventModel>();
            }
            return data;
        }
    }
}
