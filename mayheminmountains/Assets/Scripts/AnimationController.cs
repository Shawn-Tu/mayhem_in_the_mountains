using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator animator;

    private void Update()
    {
        transform.rotation = Quaternion.identity;
    }

    private void FixedUpdate()
    {
        //player move up
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("Back", true);
        }
        else
        {
            animator.SetBool("Back", false);
        }

        //player move left
        if (Input.GetKey(KeyCode.A))
        {
            animator.SetBool("Left", true);
        }
        else
        {
            animator.SetBool("Left", false);
        }

        //player move down
        if (Input.GetKey(KeyCode.S))
        {
            animator.SetBool("Forward", true);
        }
        else
        {
            animator.SetBool("Forward", false);
        }

        //player move right
        if (Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Right", true);
        }
        else
        {
            animator.SetBool("Right", false);
        }
    }
}
