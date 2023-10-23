using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
  public virtual void OnEnter() { }
  public virtual void OnExit() { }
  public virtual void PhysicsUpdate() { }
  public virtual void LogicUpdate() { }
}
