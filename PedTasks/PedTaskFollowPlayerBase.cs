
using AltV.Atlas.Peds.Shared.Interfaces;
using AltV.Atlas.Shared.Attributes;
using AltV.Net.Shared.Elements.Entities;

namespace AltV.Atlas.Peds.Shared.PedTasks;

/// <summary>
/// A task to make the ped follow the given player
/// </summary>
public abstract class PedTaskFollowPlayerBase : IPedTask
{
    private const string Identifier = "58E1B465-A689-47F7-98B3-D0F236E81052";
    
    /// <summary>
    /// The ID of this task (Unique ID used on both client and server-side to identify the task)
    /// </summary>
    [Identifier( Identifier )]
    public Guid Id { get; set; } = Guid.Parse( Identifier );

    /// <summary>
    /// The ID of the target player to follow
    /// </summary>
    public uint TargetId { get; set; }

    /// <summary>
    /// Creates a new instance of this task
    /// </summary>
    /// <param name="targetId">The ID of the target player to follow</param>
    public PedTaskFollowPlayerBase( uint targetId )
    {
        TargetId = targetId;
    }

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