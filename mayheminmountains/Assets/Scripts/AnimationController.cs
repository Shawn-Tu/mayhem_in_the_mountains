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

    //move
    const string PLAYER_WALK_L = "player_moveLeft";
    const string PLAYER_WALK_R = "player_moveRight";
    const string PLAYER_WALK_U = "player_moveUp";
    const string PLAYER_WALK_D = "player_moveDown";

    public PlayerController playerController;

    //bool determines which idle player is in
    //vertical false = Left | vertical true = Right
    //horizontal false = Up | horizontal true = Down 
    bool vertical;
    bool horizontal;

    //bool determines which direction player faces
    bool x;
    bool y;

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

        //change animation depending on direction of player movement
        if(movement.x < 0)
        {
            changeAnimationState(PLAYER_WALK_L);
            x = true;
            y = false;
            vertical = false;
        }
        else if (movement.x > 0)
        {
            changeAnimationState(PLAYER_WALK_R);
            x = true;
            y = false;
            vertical = true;
        }
        else if (movement.y > 0)
        {
            changeAnimationState(PLAYER_WALK_U);
            x = false;
            y = true;
            horizontal = false;
        }
        else if (movement.y < 0)
        {
            changeAnimationState(PLAYER_WALK_D);
            x = false;
            y = true;
            horizontal = true;
        }
        else
        {
            if (x == true & y == false)
            {
                if (vertical == false)
                {
                    changeAnimationState(PLAYER_IDLE_L);
                }
                else
                {
                    changeAnimationState(PLAYER_IDLE_R);
                }
            }
            else if (x == false & y == true)
            {
                if (horizontal == false)
                {
                    changeAnimationState(PLAYER_IDLE_U);
                }
                else
                {
                    changeAnimationState(PLAYER_IDLE_D);
                }
            }

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

    public void attackAnimationState()
    {
        //--------------------------------------------------
        //REMEMBER TO CHANGE ANIMATIONS TO ATTACK ANIMATIONS
        //--------------------------------------------------
        if (x == true & y == false)
        {
            if (vertical == false)
            {
                changeAnimationState(PLAYER_IDLE_L);
            }
            else
            {
                changeAnimationState(PLAYER_IDLE_R);
            }
        }
        else if (x == false & y == true)
        {
            if (horizontal == false)
            {
                changeAnimationState(PLAYER_IDLE_U);
            }
            else
            {
                changeAnimationState(PLAYER_IDLE_D);
            }
        }
    }
}
