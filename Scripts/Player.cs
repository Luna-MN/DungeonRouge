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
			int speed = 20;
			if (Input.IsKeyPressed(Key.W))
			{

				GD.Print(LinearVelocity);
				if (LinearVelocity.Z == 0)
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
				GD.Print(LinearVelocity);
				if (LinearVelocity.Z == 0)
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
				GD.Print(LinearVelocity);
				if (LinearVelocity.X == 0)
				{
					LinearVelocity += Vector3.Left * speed;
				}
				if (LinearVelocity.X > -20)
				{
					GD.Print("called");
					LinearVelocity += Vector3.Left;
				}
			}
			if (Input.IsKeyPressed(Key.A))
			{
				GD.Print(LinearVelocity);
				if (LinearVelocity.X == 0)
				{
					LinearVelocity += Vector3.Right * speed;
				}
				if (LinearVelocity.X < 20)
				{
					LinearVelocity += Vector3.Right;
				}
			}
		}
		if (@event is InputEventKey keyNot && !keyNot.Pressed)
		{
			LinearVelocity = new Vector3(0, 0, 0);

		}
	}
}
