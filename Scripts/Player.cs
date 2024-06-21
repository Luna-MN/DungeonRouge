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
		if (@event is InputEventKey)
		{
			int speed = 20;
			if (Input.IsKeyPressed(Key.W))
			{
				if (LinearVelocity.Z <= 1)
				{
					LinearVelocity += Vector3.Back * speed;
				}
				if (LinearVelocity.Z < 20)
				{
					LinearVelocity += Vector3.Back;
				}
			}
			if (Input.IsKeyPressed(Key.S))
			{
				if (LinearVelocity.Z >= -1)
				{
					LinearVelocity += Vector3.Forward * speed;
				}
				if (LinearVelocity.Z > -20)
				{
					LinearVelocity += Vector3.Forward;
				}
			}
			if (Input.IsKeyPressed(Key.D))
			{
				if (LinearVelocity.X >= -1)
				{
					LinearVelocity += Vector3.Left * speed;
				}
				if (LinearVelocity.X > -20)
				{
					LinearVelocity += Vector3.Left;
				}
			}
			if (Input.IsKeyPressed(Key.A))
			{
				GD.Print(LinearVelocity);
				if (LinearVelocity.X <= 1)
				{
					LinearVelocity += Vector3.Right * speed;
				}
				if (LinearVelocity.X < 20)
				{
					LinearVelocity += Vector3.Right;
				}
			}
			if (!Input.IsKeyPressed(Key.W) && !Input.IsKeyPressed(Key.S))
			{
				LinearVelocity *= new Vector3(1, 1, 0);
			}
			if (!Input.IsKeyPressed(Key.A) && !Input.IsKeyPressed(Key.D))
			{
				LinearVelocity *= new Vector3(0, 1, 1);
			}

		}

	}
}
