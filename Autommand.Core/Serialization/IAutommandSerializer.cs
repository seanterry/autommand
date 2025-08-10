namespace Autommand.Serialization;

/// <summary>
/// Defines a serializer for persisting commands as messages.
/// Implementations of this interface can be used to customize how commands are serialized.
/// Implementations are expected to honor the exception types defined in the method documentation.
/// </summary>
/// <remarks>
/// The default serializer will use System.Text.Json, but it should not be taken for granted.
/// This interface allows flexibility for different formats, as long as they can be represented as a string.
/// </remarks>
public interface IAutommandSerializer
{
    /// <summary>
    /// Serializes a command to a string representation.
    /// </summary>
    /// <param name="command">Command to serialize.</param>
    /// <typeparam name="TCommand">Type of the command.</typeparam>
    /// <returns>A string representing the serialized command.</returns>
    /// <exception cref="AutommandSerializationException">Thrown when serialization of the command fails.</exception>
    public string Serialize<TCommand>( TCommand command ) where TCommand : class;

    /// <summary>
    /// Deserializes a string representation of a command back into its original type.
    /// </summary>
    /// <param name="serializedCommand">The string representation of a command to be deserialized.</param>
    /// <typeparam name="TCommand">The type of the deserialized command.</typeparam>
    /// <returns>The deserialized command.</returns>
    /// <exception cref="AutommandSerializationException">Thrown when deserialization of the command fails.</exception>
    public TCommand Deserialize<TCommand>( string serializedCommand ) where TCommand : class;
}
