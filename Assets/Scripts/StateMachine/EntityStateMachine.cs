using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityStateMachine : StateMachine
{
  private string _currentAnimation = "";
  protected Entity _entity = null;
  public EntityIdleState IdleState { get; private set; }
  public EntityMoveState MoveState { get; private set; }

  public EntityStateMachine(Entity entity)
  {
    _entity = entity;
    SetupStates();
    Initialize();
  }

  protected override State GetInitialState()
  {
    return IdleState;
  }

  protected override void SetupStates()
  {
    IdleState = new EntityIdleState(this, _entity, "idle", _entity.MoveInput);
    MoveState = new EntityMoveState(this, _entity, "move", _entity.MoveInput, 20);
  }

  public override void ChangeState(State state)
  {
    base.ChangeState(state);
  }

  public void SetAnimation(string name)
  {
    if(!string.IsNullOrEmpty(_currentAnimation)) _entity.Animator.SetBool(name, false);
    _entity.Animator.SetBool(name, true);
  }
}
