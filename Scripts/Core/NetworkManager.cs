using Godot;
using System;

namespace ZZParty
{
	public partial class NetworkManager : Node
	{
		private const int DefaultPort = 7000;
		private const string DefaultAddress = "127.0.0.1";

		public void HebergerPartie(int port = DefaultPort, int maxClients = 4)
		{
			var peer = new ENetMultiplayerPeer();
			var error = peer.CreateServer(port, maxClients);

			if (error != Error.Ok)
			{
				GD.PrintErr($"Erreur lors de la création du serveur : {error}");
				return;
			}

			Multiplayer.MultiplayerPeer = peer;
			GD.Print($"Serveur hébergé sur le port {port}");
		}

		public void RejoindrePartie(string address = DefaultAddress, int port = DefaultPort)
		{
			var peer = new ENetMultiplayerPeer();
			var error = peer.CreateClient(address, port);

			if (error != Error.Ok)
			{
				GD.PrintErr($"Erreur lors de la connexion au serveur : {error}");
				return;
			}

			Multiplayer.MultiplayerPeer = peer;
			GD.Print($"Tentative de connexion au serveur {address}:{port}");
		}
	}
}
