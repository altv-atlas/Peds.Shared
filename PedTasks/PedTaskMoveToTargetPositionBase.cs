using AltV.Atlas.Shared.Attributes;
using AltV.Net.Data;

namespace AltV.Atlas.Peds.Shared.PedTasks;

public abstract class PedTaskMoveToTargetPositionBase
{
    private const string Identifier = "18F9B53E-840E-45EC-A209-6D058F8C2D5F";
    [Identifier( Identifier )]
    public Guid Id { get; set; } = Guid.Parse( Identifier );
    public Position TargetPosition { get; set; }

    public PedTaskMoveToTargetPositionBase( )
    {
    }
}