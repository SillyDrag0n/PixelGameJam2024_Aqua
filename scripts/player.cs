using Godot;
using System;

public partial class player : CharacterBody2D
{
	[Export]
	private int speed = 200;
	private Vector2 currentVelocity;

	public override void _PhysicsProcess(double delta)
	{
		base._PhysicsProcess(delta);
		handleInput();
		Velocity = currentVelocity;
		MoveAndSlide();
	}

	private void handleInput()
	{
		currentVelocity = Input.GetVector("player_move_left", "player_move_right", "player_move_up", "player_move_down");
		currentVelocity *= speed;
	}
}
