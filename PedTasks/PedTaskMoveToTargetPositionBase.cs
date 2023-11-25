using AltV.Atlas.Peds.Shared.Interfaces;
using AltV.Atlas.Shared.Attributes;
using AltV.Net.Data;
using AltV.Net.Shared.Elements.Entities;

namespace AltV.Atlas.Peds.Shared.PedTasks;

/// <summary>
/// A task to make the ped move(walk) to a given position
/// </summary>
public abstract class PedTaskMoveToTargetPositionBase : IPedTask
{
    private const string Identifier = "18F9B53E-840E-45EC-A209-6D058F8C2D5F";
    
    /// <summary>
    /// The ID of this task (Unique ID used on both client and server-side to identify the task)
    /// </summary>
    [Identifier( Identifier )]
    public Guid Id { get; set; } = Guid.Parse( Identifier );
    /// <summary>
    /// The target position to move to
    /// </summary>
    public Position TargetPosition { get; set; }
    
    /// <summary>
    /// Triggered when the ped starts the task. Unused on server-side
    /// </summary>
    /// <param name="ped">The ped that starts the task</param>
    /// <exception cref="NotImplementedException">throws this exception when not implemented on client-side</exception>
    public virtual void OnStart( ISharedPed ped )
    {
        throw new NotImplementedException( );
    }

    /// <summary>
    /// Triggered when the ped stops the task. Unused on server-side
    /// </summary>
    /// <exception cref="NotImplementedException">throws this exception when not implemented on client-side</exception>
    public virtual void OnStop( )
    {
        throw new NotImplementedException( );
    }
}