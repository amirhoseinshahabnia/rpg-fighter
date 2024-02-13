using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAirState : PlayerState
{

    public PlayerAirState(Player _player, PlayerStateMachine _playerStateMachine, string _animBoolname) : base(_player, _playerStateMachine, _animBoolname)
    {
    }
    public override void Enter()
    {
        base.Enter();
    }

    public override void Update()
    {
        base.Update();
        if (player.IsWallDetected())
        {
            playerStateMachine.ChangeState(player.wallSlideState);
        }

        if (player.IsGroundDetected())
        {
            playerStateMachine.ChangeState(player.idleState);
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        if (xInput != 0 && !player.IsWallDetected())
        {
            player.SetVelocity(xInput * player.moveSpeed * 0.8f, rb.velocity.y);
        }
    }

    public override void Exit()
    {
        base.Exit();
    }


}
