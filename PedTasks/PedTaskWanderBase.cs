using System.Numerics;
using AltV.Atlas.Peds.Shared.Interfaces;
using AltV.Atlas.Shared.Attributes;
using AltV.Net.Shared.Elements.Entities;

namespace AltV.Atlas.Peds.Shared.PedTasks;

public class PedTaskWanderBase : IPedTask
{
    private const string Identifier = "E73C7957-4D36-44EA-AD81-5731533DA8C0";
    [Identifier( Identifier )]
    public Guid Id { get; set; } = Guid.Parse( Identifier );
    public Vector3 Position { get; set; }
    public uint Radius { get; set; }
    public uint MinLength { get; set; }
    public uint TimeBetweenWalks { get; set; }

    public PedTaskWanderBase( Vector3 position, uint radius, uint minLength, uint timeBetweenWalks )
    {
        Position = position;
        Radius = radius;
        MinLength = minLength;
        TimeBetweenWalks = timeBetweenWalks;
    }

    public virtual void OnStart( ISharedPed ped )
    {
        throw new NotImplementedException( );
    }

    public virtual void OnStop( )
    {
        throw new NotImplementedException( );
    }
}