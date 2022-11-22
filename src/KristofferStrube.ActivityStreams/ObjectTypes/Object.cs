﻿using KristofferStrube.ActivityStreams.JsonConverters;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

/// <summary>
/// Describes an object of any kind. The Object type serves as the base type for most of the other kinds of objects defined in the Activity Vocabulary, including other Core types such as Activity, IntransitiveActivity, Collection and OrderedCollection.
/// </summary>
public class Object : ObjectOrLink
{
    /// <summary>
    /// Identifies a resource attached or related to an object that potentially requires special handling. The intent is to provide a model that is at least semantically similar to attachments in email.
    /// </summary>
    [JsonPropertyName("attachment")]
    public IEnumerable<ObjectOrLink>? Attachment { get; set; }

    /// <summary>
    /// Identifies one or more entities to which this object is attributed. The attributed entities might not be Actors. For instance, an object might be attributed to the completion of another activity.
    /// </summary>
    [JsonPropertyName("attributedTo")]
    public IEnumerable<ObjectOrLink>? AttributedTo { get; set; }

    /// <summary>
    /// Identifies one or more entities that represent the total population of entities for which the object can considered to be relevant.
    /// </summary>
    public IEnumerable<ObjectOrLink>? Audience { get; set; }

    /// <summary>
    /// Identifies one or more Objects that are part of the private secondary audience of this Object.
    /// </summary>
    public IEnumerable<ObjectOrLink>? Bcc { get; set; }

    /// <summary>
    /// Identifies an Object that is part of the private primary audience of this Object.
    /// </summary>
    public IEnumerable<ObjectOrLink>? Bto { get; set; }

    /// <summary>
    /// Identifies an Object that is part of the public secondary audience of this Object.
    /// </summary>
    public IEnumerable<ObjectOrLink>? Cc { get; set; }

    /// <summary>
    /// Identifies the context within which the object exists or an activity was performed.
    /// The notion of "context" used is intentionally vague.The intended function is to serve as a means of grouping objects and activities that share a common originating context or purpose.An example could be all activities relating to a common project or event.
    /// </summary>
    public IEnumerable<ObjectOrLink>? Context { get; set; }

    /// <summary>
    /// Identifies the entity (e.g. an application) that generated the object.
    /// </summary>
    public IEnumerable<ObjectOrLink>? Generator { get; set; }

    /// <summary>
    /// Indicates an entity that describes an icon for this object. The image should have an aspect ratio of one (horizontal) to one (vertical) and should be suitable for presentation at a small size.
    /// </summary>
    public IEnumerable<ImageOrLink>? Icon { get; set; }

    /// <summary>
    /// Indicates an entity that describes an image for this object. Unlike the icon property, there are no aspect ratio or display size limitations assumed.
    /// </summary>
    public IEnumerable<ImageOrLink>? Image { get; set; }

    /// <summary>
    /// Indicates one or more entities for which this object is considered a response.
    /// </summary>
    public IEnumerable<ObjectOrLink>? InReplyTo { get; set; }

    /// <summary>
    /// Indicates one or more physical or logical locations associated with the object.
    /// </summary>
    public IEnumerable<ObjectOrLink>? Location { get; set; }

    /// <summary>
    /// Identifies an entity that provides a preview of this object.
    /// </summary>
    public IEnumerable<ObjectOrLink>? Preview { get; set; }

    /// <summary>
    /// Identifies a Collection containing objects considered to be responses to this object.
    /// </summary>
    public Collection? Replies { get; set; }

    /// <summary>
    /// One or more "tags" that have been associated with an objects. A tag can be any kind of Object. The key difference between attachment and tag is that the former implies association by inclusion, while the latter implies associated by reference.
    /// </summary>
    public IEnumerable<ObjectOrLink>? Tag { get; set; }

    /// <summary>
    /// Identifies an entity considered to be part of the public primary audience of an Object.
    /// </summary>
    public IEnumerable<ObjectOrLink>? To { get; set; }

    /// <summary>
    /// Identifies one or more links to representations of the object.
    /// </summary>
    [JsonConverter(typeof(OneOrMultipleConverter<UriOrLink>))]
    [JsonPropertyName("url")]
    public IEnumerable<UriOrLink>? Url { get; set; }

    /// <summary>
    /// Indicates the altitude of a place. The measurement units is indicated using the units property. If units is not specified, the default is assumed to be "m" indicating meters.
    /// </summary>
    public float? Altitude { get; set; }

    /// <summary>
    /// The content or textual representation of the Object encoded as a JSON string. By default, the value of content is HTML. The mediaType property can be used in the object to indicate a different content type.
    /// The content may be expressed using multiple language-tagged values.
    /// </summary>
    /// <remarks>We haven't implimented support for the <c>rdf:langString</c> type.</remarks>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// A simple, human-readable, plain-text name for the object. HTML markup must not be included. The name may be expressed using multiple language-tagged values.
    /// </summary>
    /// <remarks>We haven't implimented support for the <c>rdf:langString</c> type.</remarks>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// When the object describes a time-bound resource, such as an audio or video, a meeting, etc, the duration property indicates the object's approximate duration. The value must be expressed as an xsd:duration as defined by [ xmlschema11-2], section 3.3.6 (e.g. a period of 5 seconds is represented as "PT5S").
    /// </summary>
    /// <remarks>We should use the XmlConvert.ToTimeSpan method.</remarks>
    public TimeSpan? Duration { get; set; }

    /// <summary>
    /// A simple, human-readable, plain-text name for the object. HTML markup must not be included. The name may be expressed using multiple language-tagged values.
    /// </summary>
    public string? MediaType { get; set; }

    /// <summary>
    /// A simple, human-readable, plain-text name for the object. HTML markup must not be included. The name may be expressed using multiple language-tagged values.
    /// </summary>
    public DateTime? EndTime { get; set; }

    /// <summary>
    /// The date and time at which the object was published.
    /// </summary>
    public DateTime? Published { get; set; }

    /// <summary>
    /// The date and time describing the actual or expected starting time of the object. When used with an Activity object, for instance, the startTime property specifies the moment the activity began or is scheduled to begin.
    /// </summary>
    public DateTime? StartTime { get; set; }

    /// <summary>
    /// A natural language summarization of the object encoded as HTML. Multiple language tagged summaries may be provided.
    /// </summary>
    /// <remarks>We haven't implimented support for the <c>rdf:langString</c> type.</remarks>
    [JsonConverter(typeof(OneOrMultipleConverter<string>))]
    [JsonPropertyName("summary")]
    public IEnumerable<string>? Summary { get; set; }

    /// <summary>
    /// 	The date and time at which the object was updated.
    /// </summary>
    public DateTime? Updated { get; set; }
}