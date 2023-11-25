
using AltV.Atlas.Peds.Shared.Interfaces;
using AltV.Atlas.Shared.Attributes;
using AltV.Net.Shared.Elements.Entities;

namespace AltV.Atlas.Peds.Shared.PedTasks;

/// <summary>
/// A task to make the ped idle (do nothing)
/// </summary>
public abstract class PedTaskIdleBase : IPedTask
{
    private const string Identifier = "169FA116-9BC7-4FF7-B628-B591BCECA6F0";
    
    /// <summary>
    /// The ID of this task (Unique ID used on both client and server-side to identify the task)
    /// </summary>
    [Identifier( Identifier )]
    public Guid Id { get; set; } = Guid.Parse( Identifier );
    
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