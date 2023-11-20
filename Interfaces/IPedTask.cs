using AltV.Net.Shared.Elements.Entities;

namespace AltV.Atlas.Peds.Shared.Interfaces;

/// <summary>
/// Base blueprint for ped task data
/// </summary>
/// 
public interface IPedTask
{
    /// <summary>
    /// The ID of the task
    /// </summary>
    Guid Id { get; set; }

    void OnStart( ISharedPed ped );
    void OnStop( );
}