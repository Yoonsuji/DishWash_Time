using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : ICharacterState
{
    public void HandleInput(PlayerMovement player)
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            player.SetState(new MoveRightState());
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            player.SetState(new MoveLeftState());
        }
        else if (Input.GetAxisRaw("Vertical") > 0)
        {
            player.SetState(new MoveUpState());
        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            player.SetState(new MoveDownState());
        }
    }

    public void Update(PlayerMovement player)
    {

    }
}
