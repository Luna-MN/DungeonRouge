using Godot;
using System;

public partial class Player : CharacterBody3D
{
	private Key oldkey;
	private int speed = 100;
	private Timer timer = new Timer();
	private bool timerOn = false;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		// Add any initialization code here
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

		Vector3 newVelocity = Vector3.Zero;
		GD.Print(Engine.GetFramesPerSecond());

		if (Input.IsKeyPressed(Key.W))
		{
			newVelocity += Vector3.Back * speed;
		}
		if (Input.IsKeyPressed(Key.S))
		{
			newVelocity += Vector3.Forward * speed;
		}
		if (Input.IsKeyPressed(Key.A))
		{
			newVelocity += Vector3.Right * speed;
		}
		if (Input.IsKeyPressed(Key.D))
		{
			newVelocity += Vector3.Left * speed;
		}

		Velocity = newVelocity;

	}

	// Called for every input event received.
	public override void _Input(InputEvent @event)
	{
		if (@event is InputEventKey keyP)
		{
		}
	}
}

