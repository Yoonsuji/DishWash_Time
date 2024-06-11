using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRightState : ICharacterState
{
    public void HandleInput(PlayerMovement player)
    {
        if (Input.GetAxisRaw("Horizontal") == 0)
        {
            player.SetState(new IdleState());
        }
    }

    public void Update(PlayerMovement player)
    {
        player.Move(Vector2.right);
        player.SetAnimation("Horizontal", 1f);
    }
}

