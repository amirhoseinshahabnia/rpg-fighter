using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWallSlideState : PlayerState
{
    public PlayerWallSlideState(Player _player, PlayerStateMachine _playerStateMachine, string _animBoolname) : base(_player, _playerStateMachine, _animBoolname)
    {
    }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Update()
    {
        base.Update();

        if (yInput < 0)
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, 0.7f * rb.velocity.y);
        }

        if (xInput != 0 && player.facingDirection != xInput)
        {
            playerStateMachine.ChangeState(player.idleState);
        }

        if (player.IsGroundDetected())
        {
            playerStateMachine.ChangeState(player.idleState);
        }
    }

    public override void Exit()
    {
        base.Exit();
    }
}
