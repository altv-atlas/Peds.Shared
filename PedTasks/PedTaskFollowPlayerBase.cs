
using AltV.Atlas.Peds.Shared.Interfaces;
using AltV.Atlas.Shared.Attributes;
using AltV.Net.Shared.Elements.Entities;

namespace AltV.Atlas.Peds.Shared.PedTasks;

public abstract class PedTaskFollowPlayerBase : IPedTask
{
    private const string Identifier = "58E1B465-A689-47F7-98B3-D0F236E81052";
    
    [Identifier( Identifier )]
    public Guid Id { get; set; } = Guid.Parse( Identifier );

    public uint TargetId { get; set; }

    public PedTaskFollowPlayerBase( uint targetId )
    {
        TargetId = targetId;
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