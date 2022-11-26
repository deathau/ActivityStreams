﻿using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

public class CollectionPage : Collection, ICollectionPageOrLink
{
    /// <summary>
    /// Identifies the Collection to which a CollectionPage objects items belong.
    /// </summary>
    [JsonPropertyName("partOf")]
    public ICollectionOrLink? PartOf { get; set; }

    /// <summary>
    /// In a paged Collection, indicates the next page of items.
    /// </summary>
    [JsonPropertyName("next")]
    public ICollectionPageOrLink? Next { get; set; }

    /// <summary>
    /// In a paged Collection, identifies the previous page of items.
    /// </summary>
    [JsonPropertyName("prev")]
    public ICollectionPageOrLink? Prev { get; set; }
}