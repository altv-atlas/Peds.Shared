using AltV.Net.Shared.Elements.Entities;

namespace AltV.Atlas.Peds.Shared.Interfaces;

/// <summary>
/// Base blueprint for atlas peds
/// </summary>
public interface IAtlasPed : ISharedPed
{
    /// <summary>
    /// The task the ped is currently doing (eg wander, follow player, etc)
    /// </summary>
    IPedTask? CurrentTask { get; }
}