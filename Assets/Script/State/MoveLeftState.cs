using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftState : ICharacterState
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
        player.Move(Vector2.left);
        player.SetAnimation("Horizontal", -1f);
    }
}