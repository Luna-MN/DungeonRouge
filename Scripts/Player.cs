using Godot;
using System;

public partial class Player : RigidBody3D
{
	private Key oldkey;
	private int speed = 20;
	private Timer timer = new Timer();
	private bool timerOn = false;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		GD.Print(timer.TimeLeft);
		if (timer.IsStopped())
		{
			speed = 20;
			timerOn = false;
		}
	}
	public override void _Input(InputEvent @event)
	{
		if (@event is InputEventKey keyP)
		{
			if (timerOn == false)
			{
				if (Input.IsKeyPressed(Key.W))
				{
					if (keyP.Pressed)
					{
						if (oldkey == Key.S)
						{
							LinearVelocity *= new Vector3(1, 1, 0);
						}
						oldkey = Key.W;
					}
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
					if (keyP.Pressed)
					{
						if (oldkey == Key.W)
						{
							LinearVelocity *= new Vector3(1, 1, 0);
						}
						oldkey = Key.S;
					}
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
					if (keyP.Pressed)
					{
						if (oldkey == Key.A)
						{
							LinearVelocity *= new Vector3(0, 1, 1);
						}
						oldkey = Key.D;
					}
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
					if (keyP.Pressed)
					{
						if (oldkey == Key.D)
						{
							LinearVelocity *= new Vector3(0, 1, 1);
						}
						oldkey = Key.A;
					}
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
			if (Input.IsKeyPressed(Key.Shift) && keyP.Pressed)
			{
				Timer timer = new Timer
				{
					Autostart = true,
					WaitTime = 0.5f,
					OneShot = true
				};
				speed = 40;
				if (oldkey == Key.W)
				{
					LinearVelocity = Vector3.Back * speed;
				}
				if (oldkey == Key.S)
				{
					LinearVelocity = Vector3.Forward * speed;
				}
				if (oldkey == Key.D)
				{
					LinearVelocity = Vector3.Left * speed;
				}
				if (oldkey == Key.A)
				{
					LinearVelocity = Vector3.Right * speed;
				}
				timerOn = true;
			}
		}

	}
}
