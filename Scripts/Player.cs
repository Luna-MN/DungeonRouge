using Godot;
using System;
using System.Linq;

public partial class Player : CharacterBody3D
{
	private Key oldkey;
	private int speed = 20;
	private Timer timer = new Timer();
	private bool timerOn = false;
	KinematicCollision3D[] kinShape3D;
	public Callable callableEntered, callableExited;


	private void AreaEntered(Node3D body)
	{
		GD.Print("Area Entered", body);
		if (body is Player)
		{
			GD.Print("Player Entered");
		}
	}
	private void AreaExited(Node3D body)
	{
		GD.Print("Area Exited", body);
		if (body is Player)
		{
			GD.Print("Player Exited");
		}
	}
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		callableEntered = new Callable(this, "AreaEntered");
		callableExited = new Callable(this, "AreaExited");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{

		Vector3 newVelocity = Vector3.Zero;

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
		MoveAndSlide();
	}

	// Called for every input event received.
	public override void _Input(InputEvent @event)
	{
		if (@event is InputEventKey keyP)
		{
		}
	}

}

