using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{
    protected PlayerStateMachine playerStateMachine;
    protected Player player;

    protected Rigidbody2D rb;

    protected float xInput;
    protected float yInput;
    private string animBoolName;
    protected float stateTimer;

    public PlayerState(Player _player, PlayerStateMachine _playerStateMachine, string _animBoolname)
    {
        player = _player;
        playerStateMachine = _playerStateMachine;
        animBoolName = _animBoolname;
    }

    public virtual void Enter()
    {
        player.animator.SetBool(animBoolName, true);
        rb = player.rb;
    }

    public virtual void Update()
    {
        stateTimer -= Time.deltaTime;

        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
        player.animator.SetFloat("yVelocity", rb.velocity.y);
    }

    public virtual void Exit()
    {
        player.animator.SetBool(animBoolName, false);
    }

}
