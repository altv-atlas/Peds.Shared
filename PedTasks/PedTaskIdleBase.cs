using AltV.Atlas.Peds.Shared.Interfaces;
using AltV.Net.Shared.Elements.Entities;

namespace AltV.Atlas.Peds.Shared.PedTasks;

/// <summary>
/// A task to make the ped idle (do nothing)
/// </summary>
public abstract class PedTaskIdleBase : IPedTask
{
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
    /// <param name="sharedPed"></param>
    /// <exception cref="NotImplementedException">throws this exception when not implemented on client-side</exception>
    public virtual void OnStop( ISharedPed sharedPed )
    {
        throw new NotImplementedException( );
    }
}