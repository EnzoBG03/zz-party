using Godot;
using System;

namespace ZZParty;

public partial class BoardSelectionUI : Control
{
    public EPartyBoard PlateauSelectionne { get; private set; } = EPartyBoard.Vallee;

    [Export]
    public Label LabelNomPlateau { get; set; }

    public override void _Ready()
    {
        UpdateLabel();
    }

    public void OnBoutonSuivantPresse()
    {
        PlateauSelectionne++;
        if (PlateauSelectionne > EPartyBoard.CyberArcadia)
        {
            PlateauSelectionne = EPartyBoard.Vallee;
        }
        UpdateLabel();
    }

    public void OnBoutonPrecedentPresse()
    {
        PlateauSelectionne--;
        if (PlateauSelectionne < EPartyBoard.Vallee)
        {
            PlateauSelectionne = EPartyBoard.CyberArcadia;
        }
        UpdateLabel();
    }

    private void UpdateLabel()
    {
        if (LabelNomPlateau != null)
        {
            LabelNomPlateau.Text = PlateauSelectionne.ToString();
        }
    }
}