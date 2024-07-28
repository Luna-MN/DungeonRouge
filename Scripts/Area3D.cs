using Godot;
using System;

public partial class Area3D : Godot.Area3D
{
	private Player player;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		player = GetTree().Root.GetNode<Player>("/root/Node3D/Player");

		GD.Print(player);
		Connect("body_entered", player.callableEntered);
		Connect("body_exited", player.callableExited);

	}
	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
}
