using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityMoveState : EntityState
{
  private IMoveInput _moveInput = null;
  private float _moveSpeed = 5;
  public EntityMoveState(EntityStateMachine stateMachine, Entity entity, string animationName, IMoveInput moveInput, float moveSpeed) : base(stateMachine, entity, animationName)
  {
    _moveInput = moveInput;
    _moveSpeed = moveSpeed;
  }

  public override void LogicUpdate()
  {
    base.LogicUpdate();
    if(!IsMoveInputPressed())
    {
      _stateMachine.ChangeState(_stateMachine.IdleState);
    }
  }

  public override void PhysicsUpdate()
  {
    base.PhysicsUpdate();
    _entity.SetVelocity(_moveInput.GetInputValue() * _moveSpeed);
  }

  public override void OnExit()
  {
    base.OnExit();
    _entity.SetVelocity(Vector2.zero);
  }

  private bool IsMoveInputPressed()
  {
    return _moveInput.GetInputValue().magnitude != 0;
  }
}
