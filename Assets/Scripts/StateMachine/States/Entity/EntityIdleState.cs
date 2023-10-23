using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityIdleState : EntityState
{
  private IMoveInput _moveInput = null;
  public EntityIdleState(EntityStateMachine stateMachine, Entity entity, string animationName, IMoveInput moveInput) : base(stateMachine, entity, animationName)
  {
    _moveInput = moveInput;
  }

  public override void LogicUpdate()
  {
    base.LogicUpdate();
    if(_moveInput == null || _moveInput.GetInputValue().magnitude != 0)
    {
      _stateMachine.ChangeState(_stateMachine.MoveState);
    }
  }
}
