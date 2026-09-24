using Godot;
using System;

namespace ZZParty;

public partial class LobbyUI : Control
{
    [Export]
    public Label LabelCodeSalon { get; set; }

    [Export]
    public MatchmakingManager Matchmaking { get; set; }

    public override void _Ready()
    {
        if (Matchmaking != null)
        {
            Matchmaking.OnCodeGenere += (code) =>
            {
                if (LabelCodeSalon != null)
                {
                    LabelCodeSalon.Text = code;
                }
            };
        }
    }

    public void OnBoutonCreerPresse()
    {
        Matchmaking?.GenererCodeSalon();
    }
}
