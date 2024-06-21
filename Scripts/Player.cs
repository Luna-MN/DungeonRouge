using Godot;
using System;

public partial class Player : RigidBody3D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	public override void _Input(InputEvent @event)
	{
		if (@event is InputEventKey keyPressed)
		{
			GD.Print("mlem");
			int speed = 10;
			if (Input.IsKeyPressed(Key.W))
			{
				GD.Print(LinearVelocity);
				if (LinearVelocity >= new Vector3(0, 0, -20))
				{
					LinearVelocity += Vector3.Forward * speed;
				}
			}
			if (Input.IsKeyPressed(Key.S))
			{
				GD.Print(LinearVelocity);
				if (LinearVelocity <= new Vector3(0, 0, 20))
				{
					LinearVelocity += Vector3.Back * speed;
				}
			}
			if (Input.IsKeyPressed(Key.D))
			{
				GD.Print(LinearVelocity);
				if (LinearVelocity >= new Vector3(-20, 0, 0))
				{
					GD.Print("called");
					LinearVelocity += Vector3.Left * speed;
				}
			}
			if (Input.IsKeyPressed(Key.A))
			{
				GD.Print(LinearVelocity);
				if (LinearVelocity <= new Vector3(20, 0, 0))
				{
					LinearVelocity += Vector3.Right * speed;
				}
			}
		}
		if (@event is InputEventKey keyNot && !keyNot.Pressed)
		{
			LinearVelocity = new Vector3(0, 0, 0);

		}
	}
}
