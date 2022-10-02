using System;
using System.Collections.Generic;
using Newtonsoft.Json.Converters;
using System.Text.Json.Serialization;

namespace RQTimer.Data.Models;

public class BossSettings
{
    public int TimerId { get; set; }

    public bool HasTrack { get; set; }

    public string? BossName { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    public BossType Type { get; set; }

    public TimeSpan RespawnTime { get; set; }

    public TimeSpan CorpsTime { get; set; }

    public TimeSpan AlertTime { get; set; }

    public List<DateTime>? KillingLog { get; set; }
}
