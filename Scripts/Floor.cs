using Godot;
using System;
using System.Collections.Generic;
/// <summary>
/// Represents a floor in the game.
/// </summary>
[Tool]
public partial class Floor : RigidBody3D
{
	[Export]
	private Mesh[] meshs;
	[Export]
	private int selected = 0;
	[Export]
	private MeshInstance3D meshInstance;
	// Called when the node enters the scene tree for the first time.
	public override void _Process(double delta)
	{
		if (selected < 0 || selected >= meshs.Length)
		{
			selected = 0;
			meshInstance.Mesh = meshs[selected];
		}
		else
		{
			meshInstance.Mesh = meshs[selected];
		}
	}
}