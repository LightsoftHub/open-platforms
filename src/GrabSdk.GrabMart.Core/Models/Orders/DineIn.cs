﻿using System.Text.Json.Serialization;

namespace Light.Grab.GrabMart.Models.Orders
{
    public class DineIn
    {
        [JsonPropertyName("tableID")]
        public string TableID { get; set; }

        [JsonPropertyName("eaterCount")]
        public int EaterCount { get; set; }
    }
}