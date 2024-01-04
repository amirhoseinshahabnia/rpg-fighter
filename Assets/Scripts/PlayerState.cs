using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState
{

    protected PlayerStateMachine playerStateMachine;
    protected Player player;

    private string animBoolName;

    public PlayerState(Player _player, PlayerStateMachine _playerStateMachine, string _animBoolname)
    {
        this.player = _player;
        this.playerStateMachine = _playerStateMachine;
        this.animBoolName = _animBoolname;
    }

    public virtual void Enter()
    {
        Debug.Log("I started " + this.animBoolName);
    }

    public virtual void Update()
    {
        Debug.Log("I am doing " + this.animBoolName);
    }

    public virtual void Exit()
    {
        Debug.Log("I am exiting " + this.animBoolName);
    }

}
