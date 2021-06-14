﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeastBot.Models
{
    class EventModel
    {

        public class Rootobject
        {
            public Class1[] Property1 { get; set; }
        }

        public class Class1
        {
            public int numberOfParticipants { get; set; }
            public int groupMemberCount { get; set; }
            public int EventId { get; set; }
            public object TimeStamp { get; set; }
            public int Version { get; set; }
            public Killer Killer { get; set; }
            public Victim Victim { get; set; }
            public int TotalVictimKillFame { get; set; }
            public object Location { get; set; }
            public Participant[] Participants { get; set; }
            public Groupmember[] GroupMembers { get; set; }
            public object GvGMatch { get; set; }
            public int BattleId { get; set; }
            public string KillArea { get; set; }
            public string Type { get; set; }
        }

        public class Killer
        {
            public float AverageItemPower { get; set; }
            public Equipment Equipment { get; set; }
            public object[] Inventory { get; set; }
            public string Name { get; set; }
            public string Id { get; set; }
            public string GuildName { get; set; }
            public string GuildId { get; set; }
            public string AllianceName { get; set; }
            public string AllianceId { get; set; }
            public string AllianceTag { get; set; }
            public string Avatar { get; set; }
            public string AvatarRing { get; set; }
            public int DeathFame { get; set; }
            public int KillFame { get; set; }
            public float FameRatio { get; set; }
            public Lifetimestatistics LifetimeStatistics { get; set; }
        }

        public class Equipment
        {
            public Mainhand MainHand { get; set; }
            public Offhand OffHand { get; set; }
            public Head Head { get; set; }
            public Armor Armor { get; set; }
            public Shoes Shoes { get; set; }
            public Bag Bag { get; set; }
            public Cape Cape { get; set; }
            public Mount Mount { get; set; }
            public Potion Potion { get; set; }
            public Food Food { get; set; }
        }

        public class Mainhand
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Offhand
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Head
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Armor
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Shoes
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Bag
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Cape
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Mount
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Potion
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Food
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Lifetimestatistics
        {
            public Pve PvE { get; set; }
            public Gathering Gathering { get; set; }
            public Crafting Crafting { get; set; }
            public int CrystalLeague { get; set; }
            public int FishingFame { get; set; }
            public int FarmingFame { get; set; }
            public object Timestamp { get; set; }
        }

        public class Pve
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
            public int Hellgate { get; set; }
            public int CorruptedDungeon { get; set; }
        }

        public class Gathering
        {
            public Fiber Fiber { get; set; }
            public Hide Hide { get; set; }
            public Ore Ore { get; set; }
            public Rock Rock { get; set; }
            public Wood Wood { get; set; }
            public All All { get; set; }
        }

        public class Fiber
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Hide
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Ore
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Rock
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Wood
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class All
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Crafting
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Victim
        {
            public float AverageItemPower { get; set; }
            public Equipment1 Equipment { get; set; }
            public Inventory[] Inventory { get; set; }
            public string Name { get; set; }
            public string Id { get; set; }
            public string GuildName { get; set; }
            public string GuildId { get; set; }
            public string AllianceName { get; set; }
            public string AllianceId { get; set; }
            public string AllianceTag { get; set; }
            public string Avatar { get; set; }
            public string AvatarRing { get; set; }
            public int DeathFame { get; set; }
            public int KillFame { get; set; }
            public float FameRatio { get; set; }
            public Lifetimestatistics1 LifetimeStatistics { get; set; }
        }

        public class Equipment1
        {
            public Mainhand1 MainHand { get; set; }
            public Offhand1 OffHand { get; set; }
            public Head1 Head { get; set; }
            public Armor1 Armor { get; set; }
            public Shoes1 Shoes { get; set; }
            public Bag1 Bag { get; set; }
            public Cape1 Cape { get; set; }
            public Mount1 Mount { get; set; }
            public Potion1 Potion { get; set; }
            public Food1 Food { get; set; }
        }

        public class Mainhand1
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Offhand1
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Head1
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Armor1
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Shoes1
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Bag1
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Cape1
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Mount1
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Potion1
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Food1
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Lifetimestatistics1
        {
            public Pve1 PvE { get; set; }
            public Gathering1 Gathering { get; set; }
            public Crafting1 Crafting { get; set; }
            public int CrystalLeague { get; set; }
            public int FishingFame { get; set; }
            public int FarmingFame { get; set; }
            public object Timestamp { get; set; }
        }

        public class Pve1
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
            public int Hellgate { get; set; }
            public int CorruptedDungeon { get; set; }
        }

        public class Gathering1
        {
            public Fiber1 Fiber { get; set; }
            public Hide1 Hide { get; set; }
            public Ore1 Ore { get; set; }
            public Rock1 Rock { get; set; }
            public Wood1 Wood { get; set; }
            public All1 All { get; set; }
        }

        public class Fiber1
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Hide1
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Ore1
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Rock1
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Wood1
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class All1
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Crafting1
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Inventory
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Participant
        {
            public float AverageItemPower { get; set; }
            public Equipment2 Equipment { get; set; }
            public object[] Inventory { get; set; }
            public string Name { get; set; }
            public string Id { get; set; }
            public string GuildName { get; set; }
            public string GuildId { get; set; }
            public string AllianceName { get; set; }
            public string AllianceId { get; set; }
            public string AllianceTag { get; set; }
            public string Avatar { get; set; }
            public string AvatarRing { get; set; }
            public int DeathFame { get; set; }
            public int KillFame { get; set; }
            public float FameRatio { get; set; }
            public Lifetimestatistics2 LifetimeStatistics { get; set; }
            public float DamageDone { get; set; }
            public float SupportHealingDone { get; set; }
        }

        public class Equipment2
        {
            public Mainhand2 MainHand { get; set; }
            public Offhand2 OffHand { get; set; }
            public Head2 Head { get; set; }
            public Armor2 Armor { get; set; }
            public Shoes2 Shoes { get; set; }
            public Bag2 Bag { get; set; }
            public Cape2 Cape { get; set; }
            public Mount2 Mount { get; set; }
            public Potion2 Potion { get; set; }
            public Food2 Food { get; set; }
        }

        public class Mainhand2
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Offhand2
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Head2
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Armor2
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Shoes2
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Bag2
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Cape2
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Mount2
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Potion2
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Food2
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Lifetimestatistics2
        {
            public Pve2 PvE { get; set; }
            public Gathering2 Gathering { get; set; }
            public Crafting2 Crafting { get; set; }
            public int CrystalLeague { get; set; }
            public int FishingFame { get; set; }
            public int FarmingFame { get; set; }
            public object Timestamp { get; set; }
        }

        public class Pve2
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
            public int Hellgate { get; set; }
            public int CorruptedDungeon { get; set; }
        }

        public class Gathering2
        {
            public Fiber2 Fiber { get; set; }
            public Hide2 Hide { get; set; }
            public Ore2 Ore { get; set; }
            public Rock2 Rock { get; set; }
            public Wood2 Wood { get; set; }
            public All2 All { get; set; }
        }

        public class Fiber2
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Hide2
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Ore2
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Rock2
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Wood2
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class All2
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Crafting2
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Groupmember
        {
            public float AverageItemPower { get; set; }
            public Equipment3 Equipment { get; set; }
            public object[] Inventory { get; set; }
            public string Name { get; set; }
            public string Id { get; set; }
            public string GuildName { get; set; }
            public string GuildId { get; set; }
            public string AllianceName { get; set; }
            public string AllianceId { get; set; }
            public string AllianceTag { get; set; }
            public string Avatar { get; set; }
            public string AvatarRing { get; set; }
            public int DeathFame { get; set; }
            public int KillFame { get; set; }
            public float FameRatio { get; set; }
            public Lifetimestatistics3 LifetimeStatistics { get; set; }
        }

        public class Equipment3
        {
            public Mainhand3 MainHand { get; set; }
            public object OffHand { get; set; }
            public object Head { get; set; }
            public object Armor { get; set; }
            public object Shoes { get; set; }
            public object Bag { get; set; }
            public object Cape { get; set; }
            public object Mount { get; set; }
            public object Potion { get; set; }
            public object Food { get; set; }
        }

        public class Mainhand3
        {
            public string Type { get; set; }
            public int Count { get; set; }
            public int Quality { get; set; }
            public object[] ActiveSpells { get; set; }
            public object[] PassiveSpells { get; set; }
        }

        public class Lifetimestatistics3
        {
            public Pve3 PvE { get; set; }
            public Gathering3 Gathering { get; set; }
            public Crafting3 Crafting { get; set; }
            public int CrystalLeague { get; set; }
            public int FishingFame { get; set; }
            public int FarmingFame { get; set; }
            public object Timestamp { get; set; }
        }

        public class Pve3
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
            public int Hellgate { get; set; }
            public int CorruptedDungeon { get; set; }
        }

        public class Gathering3
        {
            public Fiber3 Fiber { get; set; }
            public Hide3 Hide { get; set; }
            public Ore3 Ore { get; set; }
            public Rock3 Rock { get; set; }
            public Wood3 Wood { get; set; }
            public All3 All { get; set; }
        }

        public class Fiber3
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Hide3
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Ore3
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Rock3
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Wood3
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class All3
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

        public class Crafting3
        {
            public int Total { get; set; }
            public int Royal { get; set; }
            public int Outlands { get; set; }
            public int Avalon { get; set; }
        }

    }
}
