﻿namespace Gossip.SQLite.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public int ChannelId { get; set; }
        public Channel Channel { get; set; }
    }
}