namespace Autommand;

/// <summary>
/// Defines the client interface for dispatching commands.
/// </summary>
public interface IAutommandClient
{
    /// <summary>
    /// Dispatches the given command to the appropriate handler.
    /// </summary>
    /// <param name="command">Command to execute.</param>
    /// <param name="cancellationToken">Token for cancelling the dispatch.</param>
    /// <typeparam name="TCommand">Type of the command.</typeparam>
    /// <returns>
    /// An awaitable task representing a unique identifier that can be used to track the command's execution or
    /// correlate it with other operations. The task will complete when the command has been successfully enqueued for
    /// execution.
    /// </returns>
    public Task<Guid> Dispatch<TCommand>( TCommand command, CancellationToken cancellationToken = default );
}
