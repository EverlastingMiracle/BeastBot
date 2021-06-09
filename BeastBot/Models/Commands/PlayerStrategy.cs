using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;
using System.Net.Http.Json;
using System.Net.Http;
using BeastBot.Models;

namespace BeastBot.Models.Commands
{
    class PlayerStrategy : IStrategy
    {
        public async Task DoAlgorithm(Message message, TelegramBotClient client)
        {
            HttpClient httpClient = new HttpClient();
            string rootUri = "https://gameinfo.albiononline.com/api/gameinfo/search?q=";
            string playerName =  message.Text.Replace("find player", "").Trim(' ');
            string requestString = rootUri+ playerName;
            var request = new HttpRequestMessage(HttpMethod.Get, requestString);
            DataModel result;
            result = await GetUserAsync(request, httpClient);
            
                 client.SendTextMessageAsync(message.Chat.Id, result.Players.Length.ToString());


                 ShowPlayerData(message, client, result);
            
        }


        private async Task<DataModel> GetUserAsync(HttpRequestMessage path, HttpClient httpClient)
        {
            DataModel data = null;
            HttpResponseMessage response = await httpClient.SendAsync(path);
            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadFromJsonAsync<DataModel>();
            }
            return data;
        }

        private void ShowPlayerData(Message message, TelegramBotClient client, DataModel model) 
        {
            client.SendTextMessageAsync(message.Chat.Id, "STAAAER");
            client.SendTextMessageAsync(message.Chat.Id, model.Players.Length.ToString());
            Player current = model.Players[0];
            client .SendTextMessageAsync(message.Chat.Id, $"Player with nickname {current.Name}");
        }



    }
}
