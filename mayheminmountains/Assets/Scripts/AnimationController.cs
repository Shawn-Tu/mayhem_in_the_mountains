using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;
    string currentState;
    //idle
    const string PLAYER_IDLE_L = "player_idleLeft";
    const string PLAYER_IDLE_R = "player_idleRight";
    const string PLAYER_IDLE_U = "player_idleUp";
    const string PLAYER_IDLE_D = "player_idleDown";

    const string PLAYER_IDLE = PLAYER_IDLE_U;

    //move
    const string PLAYER_WALK_L = "player_moveLeft";
    const string PLAYER_WALK_R = "player_moveRight";
    const string PLAYER_WALK_U = "player_moveUp";
    const string PLAYER_WALK_D = "player_moveDown";

    Vector2 movement;

    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    private void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        transform.rotation = Quaternion.identity;

        if(movement.x < 0)
        {
            changeAnimationState(PLAYER_WALK_L);
        }
        else if (movement.x > 0)
        {
            changeAnimationState(PLAYER_WALK_R);
        }
        else if (movement.y > 0)
        {
            changeAnimationState(PLAYER_WALK_U);
        }
        else if (movement.y < 0)
        {
            changeAnimationState(PLAYER_WALK_D);
        }
        else
        {
            changeAnimationState(PLAYER_IDLE);
        }
    }

    //animation change
    void changeAnimationState(string newState)
    {
        //no more animation interrupting
        if (currentState == newState) return;

        //New animation is to be played
        animator.Play(newState);

        //update state
        currentState = newState;
    }
}
