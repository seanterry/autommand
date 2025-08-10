using System.Text.Json;

namespace Autommand.Serialization.Json;

/// <summary>
/// Serializer using System.Text.Json.
/// </summary>
/// <param name="options">Options for controlling serialization.</param>
public sealed class JsonAutommandSerializer( JsonAutommandSerializerOptions options ) : IAutommandSerializer
{
    /// <inheritdoc />
    public string Serialize<TCommand>( TCommand command ) where TCommand : class
    {
        try
        {
            return JsonSerializer.Serialize( command, options.SerializerOptions );
        }

        catch ( Exception e )
        {
            throw new AutommandSerializationException( "The command could not be serialized.", typeof(TCommand), e );
        }
    }

    /// <inheritdoc />
    public TCommand Deserialize<TCommand>( string serializedCommand ) where TCommand : class
    {
        try
        {
            return JsonSerializer.Deserialize<TCommand>( serializedCommand, options.SerializerOptions ) ??
                throw new AutommandSerializationException( "The command could not be deserialized.", typeof(TCommand) );
        }

        catch ( Exception e ) when ( e is not AutommandSerializationException )
        {
            throw new AutommandSerializationException( "The command could not be deserialized.", typeof(TCommand), e );
        }
    }
}
