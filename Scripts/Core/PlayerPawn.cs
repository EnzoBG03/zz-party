using Godot;

namespace ZZParty;

public partial class PlayerPawn : Node3D
{
    [Export] public BoardPath CheminPlateau { get; set; }

    public int IndexCaseActuelle { get; private set; } = 0;

    public void AvancerDe(int nombreCases)
    {
        IndexCaseActuelle += nombreCases;

        if (CheminPlateau != null)
        {
            Vector3 destination = CheminPlateau.ObtenirPositionCase(IndexCaseActuelle);
            GetTree().CreateTween().TweenProperty(this, "global_position", destination, 0.5f);
        }
    }
}
