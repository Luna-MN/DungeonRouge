using Godot;
using System;
using System.Linq.Expressions;

public partial class enemy : CharacterBody3D
{
	private Player player;
	[Export]
	public PackedScene area;
	public Timer timer;
	public MeshInstance3D mesh3D;

	// possible player chase??
	public override void _PhysicsProcess(double delta)
	{

		MoveAndSlide();
	}
	public override void _Ready()
	{
		player = GetTree().Root.GetNode<Player>("/root/Node3D/Player");
		timer = new Timer { WaitTime = 5, OneShot = true, Autostart = false };
		timer.Start();
	}
	public override void _Process(double delta)
	{
		if (timer.IsStopped())
		{
			mesh3D = area.Instantiate<MeshInstance3D>();
			timer.Start();
		}
	}
}

