
using AltV.Atlas.Shared.Attributes;

namespace AltV.Atlas.Peds.Shared.PedTasks;

public class PedTaskIdleBase
{
    private const string Identifier = "169FA116-9BC7-4FF7-B628-B591BCECA6F0";
    
    [Identifier( Identifier )]
    public Guid Id { get; set; } = Guid.Parse( Identifier );
}