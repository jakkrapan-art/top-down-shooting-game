using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveInput : IMoveInput
{
  public Vector2 GetInputValue()
  {
    return new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
  }
}
