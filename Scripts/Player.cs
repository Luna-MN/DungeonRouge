using Godot;
using System;
using System.Linq;

public partial class Player : CharacterBody3D
{
	[Export]
	public MeshInstance3D mesh;
	private Key oldkey;
	private int speed = 20;
	public Timer timer = new Timer { WaitTime = 10, OneShot = true, Autostart = false };
	private bool Entered = false;
	KinematicCollision3D[] kinShape3D;
	public Callable callableEntered, callableExited;

	private void AreaEntered(Node3D body)
	{
		GD.Print("Area Entered", body);
		if (body is Player)
		{
			GD.Print("Player Entered");
			Entered = true;
		}
	}
	private void AreaExited(Node3D body)
	{
		GD.Print("Area Exited", body);
		if (body is Player)
		{
			GD.Print("Player Exited");
			Entered = false;
		}
	}
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		callableEntered = new Callable(this, "AreaEntered");
		callableExited = new Callable(this, "AreaExited");
		AddChild(timer);
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
		/* when we have aoe creation make this into a for each loop for all meshes
		and check if the player is in the aoe is the same because it doesn't matter
		which AOE their in they will still take damage*/
		if (timer.IsStopped())
		{
			if (Entered)
			{
				GD.Print("Player Damage");

			}
			mesh.QueueFree();
		}
	}

	// Called for every input event received.
	public override void _Input(InputEvent @event)
	{
		if (@event is InputEventKey keyP)
		{
		}
	}

}

