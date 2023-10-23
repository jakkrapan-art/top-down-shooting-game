using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StateMachine
{
  public StateMachine() {}
  public State CurrentState { get; protected set; }

  public virtual void ChangeState(State state)
  {
    if (CurrentState != null) CurrentState.OnExit();

    CurrentState = state;
    CurrentState.OnEnter();
  }

  public void Initialize()
  {
    CurrentState = GetInitialState();
    CurrentState.OnEnter();
  }

  public void PhysicsUpdate() { if(CurrentState != null) CurrentState.PhysicsUpdate(); }
  public void LogicUpdate() { if (CurrentState != null) CurrentState.LogicUpdate(); }

  protected abstract void SetupStates();
  protected abstract State GetInitialState();
}
