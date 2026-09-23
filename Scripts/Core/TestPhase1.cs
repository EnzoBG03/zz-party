using Godot;
using ZZParty;

public partial class TestPhase1 : Node
{
    [Export] public DiceRoller MonDe { get; set; }
    [Export] public PlayerPawn MonJoueur { get; set; }

    public override void _UnhandledInput(InputEvent @event)
    {
        // Appuie sur Espace ou Entrée pour déclencher l'action
        if (@event.IsActionPressed("ui_accept"))
        {
            int resultat = MonDe.LancerDe();
            GD.Print($"Le dé affiche : {resultat}");
            MonJoueur.AvancerDe(resultat);
        }
    }
}