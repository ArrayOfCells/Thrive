﻿using Newtonsoft.Json;

/// <summary>
///   Population effect external to the auto-evo simulation
/// </summary>
public class ExternalEffect
{
    public ExternalEffect(Species species, int constant, float coefficient, string eventType, Patch patch,
        bool playerDeath)
    {
        Species = species;
        Constant = constant;
        Coefficient = coefficient;
        EventType = eventType;
        Patch = patch;
        PlayerDeath = playerDeath;
    }

    [JsonProperty]
    public Species Species { get; }

    [JsonProperty]
    public int Constant { get; set; }

    [JsonProperty]
    public float Coefficient { get; set; }

    [JsonProperty]
    public string EventType { get; set; }

    [JsonProperty]
    public Patch Patch { get; set; }

    [JsonProperty]
    public bool PlayerDeath { get; set; }
}
