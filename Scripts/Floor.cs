using Godot;
using System;
using System.Collections.Generic;
[Tool]
public partial class Floor : RigidBody3D
{
	[Export]
	private Mesh[] meshs;
	[Export]
	private int selected;

	public Floor()
	{
	}
	[Export]
	private MeshInstance3D meshInstance;
	private enum Choices
	{
		one,
		two,
		three,
		four,
		five,
		six

	}
	// Called when the node enters the scene tree for the first time.
	public override void _Process(double delta)
	{
		if (selected < 0 || selected >= meshs.Length)
		{
			selected = 0;
		}
		meshInstance.Mesh = meshs[selected];
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public void meshUpdate()
	{
		if (selected < 0 || selected >= meshs.Length)
		{
			selected = 0;
		}
		meshInstance.Mesh = meshs[selected];
	}
}