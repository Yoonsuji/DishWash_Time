using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;
    private Animator animator;
    private ICharacterState currentState;

    Vector2 movement = new Vector2 ();

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        currentState = new IdleState();
    }

    void Update()
    {
        currentState.HandleInput(this);
        currentState.Update(this);
    }

    public void SetState(ICharacterState newState)
    {
        currentState = newState;
    }

    public void Move(Vector2 direction)
    {
        rb.MovePosition(rb.position + direction * moveSpeed * Time.fixedDeltaTime);
        if (Mathf.Approximately(movement.x, 0) && Mathf.Approximately(movement.y, 0))
        {
            animator.SetBool("isMove", true);
        }
        else
        {
            animator.SetBool("isMove", false);
        }
    }

    public void SetAnimation(string parameter, float value)
    {
        animator.SetFloat(parameter, value);
        animator.SetFloat("Speed", 0.5f); 
    }
}

