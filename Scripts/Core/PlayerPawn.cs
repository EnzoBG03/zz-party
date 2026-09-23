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
            float distanceDepart = (IndexCaseActuelle - nombreCases) * CheminPlateau.DistanceEntreCases;
            float distanceArrivee = IndexCaseActuelle * CheminPlateau.DistanceEntreCases;
            GetTree().CreateTween().TweenMethod(Callable.From<float>(MettreAJourPositionSurCourbe), distanceDepart, distanceArrivee, 0.5f * nombreCases);
        }
    }

    private void MettreAJourPositionSurCourbe(float distance)
    {
        GlobalPosition = CheminPlateau.Curve.SampleBaked(distance);
    }
}
