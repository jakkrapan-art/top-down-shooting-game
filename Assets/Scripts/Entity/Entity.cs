using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
  protected EntityStateMachine _stateMachine = null;
  public Animator Animator { get; protected set; } = null;
  private Rigidbody2D _rb;
  public IMoveInput MoveInput { get; protected set; }

  protected virtual void Awake()
  {
    _rb = GetComponent<Rigidbody2D>();
    Animator = GetComponent<Animator>();

    _stateMachine = new EntityStateMachine(this);
  }

  protected virtual void Update()
  {
    if (_stateMachine != null) _stateMachine.LogicUpdate();
  }

  protected virtual  void FixedUpdate()
  {
    if (_stateMachine != null) _stateMachine.PhysicsUpdate();
  }

  public void SetVelocity(Vector2 velocity)
  {
    if(_rb)
    {
      _rb.velocity = velocity;
    }
  }
}
