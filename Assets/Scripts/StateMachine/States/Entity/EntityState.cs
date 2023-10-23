using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityState : State
{
  private string _animationName;
  protected EntityStateMachine _stateMachine;
  protected Entity _entity;
  public EntityState(EntityStateMachine stateMachine, Entity entity, string animationName)
  {
    _stateMachine = stateMachine;
    _entity = entity;
    _animationName = animationName;
  }
  public override void OnEnter()
  {
    base.OnEnter();
    _stateMachine.SetAnimation(_animationName);
  }
}
