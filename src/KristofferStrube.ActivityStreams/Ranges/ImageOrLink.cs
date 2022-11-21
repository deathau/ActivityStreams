﻿using System.Text.Json.Serialization;

namespace KristofferStrube.ActivityStreams;

[JsonDerivedType(typeof(Image), "Image")]
[JsonDerivedType(typeof(Link), "Link")]
public interface ImageOrLink
{

}
