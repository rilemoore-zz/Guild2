using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace App2.Stuff
{
    public class GameEvent
    {
        [JsonProperty("EventTitle")]
        public string EventTitle;

        [JsonProperty("End Time")]
        public string EndTime;

        [JsonProperty("Event Date")]
        public string EventDate;

        [JsonProperty("User ID")]
        public string UserId;

        [JsonProperty("Event Game")]
        public string EventGame;

        [JsonProperty("Platform")]
        public string Platform;

        [JsonProperty("Number of Players")]
        public string numberOfPlayers;

        [JsonProperty("Event ID")]
        public string eventId;
    }
}
