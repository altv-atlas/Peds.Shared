using System.Numerics;
using AltV.Atlas.Peds.Shared.Interfaces;
using AltV.Net.Shared.Elements.Entities;

namespace AltV.Atlas.Peds.Shared.PedTasks;

/// <summary>
/// A task to make the ped wander around in an area
/// </summary>
public abstract class PedTaskWanderBase : IPedTask
{
    /// <summary>
    /// The position to wander around
    /// </summary>
    public Vector3 Position { get; set; }
    /// <summary>
    /// Radius from position the ped can wander in
    /// </summary>
    public uint Radius { get; set; }
    /// <summary>
    /// Minimum length of a walk
    /// </summary>
    public uint MinLength { get; set; }
    /// <summary>
    /// Time the ped waits between walks
    /// </summary>
    public uint TimeBetweenWalks { get; set; }

    /// <summary>
    /// Creates a new wander task
    /// </summary>
    /// <param name="position">The position to wander around</param>
    /// <param name="radius">Radius from position the ped can wander in</param>
    /// <param name="minLength">Minimum length of a walk</param>
    /// <param name="timeBetweenWalks">Time the ped waits between walks</param>
    protected PedTaskWanderBase( Vector3 position, uint radius, uint minLength, uint timeBetweenWalks )
    {
        Position = position;
        Radius = radius;
        MinLength = minLength;
        TimeBetweenWalks = timeBetweenWalks;
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
    /// <param name="sharedPed"></param>
    /// <exception cref="NotImplementedException">throws this exception when not implemented on client-side</exception>
    public virtual void OnStop( ISharedPed sharedPed )
    {
        throw new NotImplementedException( );
    }
}