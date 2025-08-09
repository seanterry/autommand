namespace Autommand;

/// <summary>
/// Defines a context for command execution. This context can be used to access information about the command being
/// executed and to manipulate its execution.
/// </summary>
public interface IAutommandContext
{
    /// <summary>
    /// Gets the unique identifier of the command being executed.
    /// This identifier can be used to track the command's execution or to correlate it with other operations.
    /// </summary>
    public Guid CommandId { get; }
}
