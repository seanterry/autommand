using System.Diagnostics.CodeAnalysis;

namespace Autommand;

/// <summary>
/// Defines a handler for a specific command type.
/// </summary>
/// <typeparam name="TCommand">
/// Type of the command.
/// Any serializable class or record can be used.
/// </typeparam>
[SuppressMessage("ReSharper", "TypeParameterCanBeVariant")]
public interface IAutommandHandler<TCommand> where TCommand : class
{
    /// <summary>
    /// Handles execution of the command.
    /// </summary>
    /// <param name="command">Command arguments.</param>
    /// <param name="context">Execution context.</param>
    /// <param name="cancellationToken">Token for canceling the command.</param>
    /// <returns>An awaitable <see cref="Task"/> representing the method's completion.</returns>
    public Task HandleAsync( TCommand command, IAutommandContext context, CancellationToken cancellationToken );
}
