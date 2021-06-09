using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeastBot.Models
{
    class DataModel
    { 
        public Guild[] Guilds { get; set; }
        public Player[] Players { get; set; }
    }

    public class Guild
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string AllianceId { get; set; }
        public string AllianceName { get; set; }
        public object KillFame { get; set; }
        public long DeathFame { get; set; }
    }

    public class Player
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string GuildId { get; set; }
        public string GuildName { get; set; }
        public string AllianceId { get; set; }
        public string AllianceName { get; set; }
        public string Avatar { get; set; }
        public string AvatarRing { get; set; }
        public int KillFame { get; set; }
        public int DeathFame { get; set; }
        public float FameRatio { get; set; }
        public object totalKills { get; set; }
        public object gvgKills { get; set; }
        public object gvgWon { get; set; }

        public void Show()
        {
            Console.WriteLine(this.Name);
        }
    }
}
