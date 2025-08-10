using System.Text.Json;

namespace Autommand.Serialization.Json;

/// <summary>
/// Options for JSON serialization in Autommand.
/// </summary>
/// <param name="SerializerOptions">Options for the underlying serializer.</param>
public record JsonAutommandSerializerOptions( JsonSerializerOptions SerializerOptions );
