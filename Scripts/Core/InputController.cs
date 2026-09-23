using Godot;

namespace ZZParty;

public partial class InputController : Node
{
	public bool EstToucheActionPressee(int idJoueur)
	{
		return false;
	}

	public bool EstToucheAnnulationPressee(int idJoueur)
	{
		return false;
	}

	public Vector2 ObtenirVecteurMouvement(int idJoueur)
	{
		return Vector2.Zero;
	}
}
