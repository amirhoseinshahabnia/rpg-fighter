using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerIdleState : PlayerGroundState
{
  public PlayerIdleState(Player _player, PlayerStateMachine _playerStateMachine, string _animBoolName) : base(_player, _playerStateMachine, _animBoolName)
  {

  }

  public override void Enter()
  {
    base.Enter();
  }

  public override void Update()
  {
    base.Update();

    if (xInput == player.facingDirection && player.IsWallDetected())
    {
      return;
    }

    if (xInput != 0)
    {
      playerStateMachine.ChangeState(player.moveState);
    }
  }

  public override void Exit()
  {
    base.Exit();
  }
}
