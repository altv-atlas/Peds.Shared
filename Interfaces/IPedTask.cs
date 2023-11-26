using AltV.Net.Shared.Elements.Entities;

namespace AltV.Atlas.Peds.Shared.Interfaces;

/// <summary>
/// Base blueprint for ped task data
/// </summary>
/// 
public interface IPedTask
{
    /// <summary>
    /// Triggered on client-side when the task starts (eg on stream-in)
    /// </summary>
    /// <param name="ped">The ped it started on</param>
    void OnStart( ISharedPed ped );

    /// <summary>
    /// Triggered on client-side when the task needs to stop (eg on stream-out)
    /// </summary>
    /// <param name="sharedPed"></param>
    void OnStop( ISharedPed sharedPed );
}