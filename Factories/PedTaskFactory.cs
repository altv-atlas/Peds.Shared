using AltV.Atlas.Peds.Shared.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace AltV.Atlas.Peds.Shared.Factories;

/// <summary>
/// A factory that can be injected via DI and used to create a new ped task
/// </summary>
public class PedTaskFactory
{
    private readonly IServiceProvider _serviceProvider;
    /// <summary>
    /// The ped task factory
    /// </summary>
    /// <param name="serviceProvider">A service provider</param>
    public PedTaskFactory( IServiceProvider serviceProvider )
    {
        _serviceProvider = serviceProvider;
    }

    /// <summary>
    /// Creates a new ped task of the given type, with the given parameters
    /// </summary>
    /// <param name="parameters">The parameters that are required for the given ped task</param>
    /// <typeparam name="T">The ped task to create</typeparam>
    /// <returns></returns>
    public T CreatePedTask<T>( params object[ ] parameters ) where T : IPedTask
    {
        return ActivatorUtilities.CreateInstance<T>( _serviceProvider, parameters );
    }
}