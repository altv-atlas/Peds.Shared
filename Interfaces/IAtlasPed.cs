using AltV.Net.Shared.Elements.Entities;

namespace AltV.Atlas.Peds.Shared.Interfaces;

/// <summary>
/// Base blueprint for atlas peds
/// </summary>
public interface IAtlasPed : ISharedPed
{
    IPedTask? CurrentTask { get; }
    /// <summary>
    /// Give the ped a specific task
    /// </summary>
    /// <param name="pedTask">The ped task</param>>
    void SetPedTask<T>( T pedTask ) where T : class, IPedTask;
}