using Godot;
using System;

public partial class Player : Node
{

	//Definir a velocidade do personagem;
	private Vector2 _speed = new Vector2(400,0);

	//Criar força de salto
	private float _jumpvelocity = 600.0f;

	//Força de gravidade
	private float gravity = 1000.0f;

	//Referencia ao sprite
	private Sprite2D _sprite;

	private Vector2 velocity = Vector2.Zero;
	
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		//
		_sprite = GetNode<Sprite2D>("Sprite2D");
	
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.

public override void _Process(double delta)
{
	//Atualiza a posição dp personagem com base na velocidade e tempo
	_sprite.Position += _speed * (float)delta;
	//Se o personagem ultrapassar a posição X de 1000
	if (_sprite.Position.X > 1000)
	{
		//Reposiciona o personagem na posição inicial
		_sprite.Position = new Vector2(-100, 350);
	}
}
}