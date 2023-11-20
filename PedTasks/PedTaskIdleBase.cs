
using AltV.Atlas.Peds.Shared.Interfaces;
using AltV.Atlas.Shared.Attributes;
using AltV.Net.Shared.Elements.Entities;

namespace AltV.Atlas.Peds.Shared.PedTasks;

public class PedTaskIdleBase : IPedTask
{
    private const string Identifier = "169FA116-9BC7-4FF7-B628-B591BCECA6F0";
    
    [Identifier( Identifier )]
    public Guid Id { get; set; } = Guid.Parse( Identifier );

    public virtual void OnStart( ISharedPed ped )
    {
        throw new NotImplementedException( );
    }

    public virtual void OnStop( )
    {
        throw new NotImplementedException( );
    }
}