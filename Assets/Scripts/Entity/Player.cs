using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
  protected override void Awake()
  {
    MoveInput = new PlayerMoveInput();
    base.Awake();
  }
}
