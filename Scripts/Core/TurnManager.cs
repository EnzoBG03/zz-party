using Godot;

namespace ZZParty;

public partial class TurnManager : Node
{
	public int JoueurActuel { get; private set; } = 1;
	public int NombreDeJoueurs { get; set; } = 4;

	public void PasserAuJoueurSuivant()
	{
		JoueurActuel++;
		if (JoueurActuel > NombreDeJoueurs)
		{
			JoueurActuel = 1;
		}
	}
}
