using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;
using BeastBot.Models;


namespace BeastBot
{
    class Program
    {
       
        static void Main(string[] args)
        {
            var Bo = Bot.Get().GetAwaiter().GetResult(); ;           
                Bo.StartReceiving();
                Bo.OnMessage += Bot.Bot_OnMessage;
                Console.ReadLine();          
            
        }       
    }
}
