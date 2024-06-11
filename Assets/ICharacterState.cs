using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacterState
{
    void HandleInput(PlayerMovement player);
    void Update(PlayerMovement player);
}
