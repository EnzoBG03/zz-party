using Godot;

namespace ZZParty;

public partial class MainMenuUI : Control
{
    public void OnBoutonJouerPresse()
    {
        GetTree().ChangeSceneToFile("res://Scenes/LobbyMenu.tscn");
    }

    public void OnBoutonQuitterPresse()
    {
        GetTree().Quit();
    }
}
