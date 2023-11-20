using AltV.Net.Shared.Elements.Entities;

namespace AltV.Atlas.Peds.Shared.Interfaces;

/// <summary>
/// Base blueprint for atlas peds
/// </summary>
public interface IAtlasPed : ISharedPed
{
    IPedTask? CurrentTask { get; }
}