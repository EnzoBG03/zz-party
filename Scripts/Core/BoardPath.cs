using Godot;

namespace ZZParty;

public partial class BoardPath : Path3D
{
    [Export] public float DistanceEntreCases { get; set; } = 2.0f;

    public Vector3 ObtenirPositionCase(int indexCase)
    {
        if (Curve == null)
        {
            return Vector3.Zero;
        }

        float distance = indexCase * DistanceEntreCases;
        return Curve.SampleBaked(distance);
    }
}
