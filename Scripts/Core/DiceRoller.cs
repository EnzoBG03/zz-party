using Godot;
using System;

namespace ZZParty;

public partial class DiceRoller : Node
{
	private Random _random = new Random();

	public int LancerDe()
	{
		return _random.Next(1, 7);
	}
}
