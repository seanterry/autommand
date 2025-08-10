namespace Autommand.Serialization;

/// <summary>
/// An exception that is thrown when there is an error during the serialization or deserialization of a command.
/// </summary>
/// <param name="type">Type of the command.</param>
/// <param name="message">Message to include in the exception.</param>
/// <param name="innerException">Exception that caused the current exception.</param>
public sealed class AutommandSerializationException( string message, Type type, Exception? innerException = null )
    : Exception( message, innerException );
