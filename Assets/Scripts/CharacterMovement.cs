using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
[Range(0, .3f)] public float MovementSmoothing = .05f ; // How much to smooth out the movement
//public float JumpForce = 400f ; // Amount of force added when the player jumps .
public float MoveForce = 10f ; // Amount of force added when the player jumps .
public LayerMask Ground;// A mask determining what is ground to the character
private Rigidbody2D rb;
private Animator myAnimator;
private BoxCollider2D bCollider;
private Vector3 currentVelocity = Vector3.zero;
private int jumpCounter = 0;
private float jumpForce = 10.0f;
private bool doubleJumped = false;




    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
        bCollider = GetComponent <BoxCollider2D>(); 
        rb = GetComponent<Rigidbody2D>();
        
      
    }


    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        if (DialogueManager.isTalking == false)
        {
            // Move the character by finding the target velocity
            Vector3 targetVelocity = new Vector2(move * MoveForce, rb.velocity.y);

            // And then smoothing it out and applying it to the character
            rb.velocity = Vector3.SmoothDamp(rb.velocity, targetVelocity, ref currentVelocity,
            MovementSmoothing);

            // This will flip the character to face left when walking left and right when turning right. 
            if (move < 0)
            {
                transform.localScale = new Vector2(-1, 1);
            }
            else
            {
                transform.localScale = new Vector2(1, 1);
            }

            // Jump controls including double jump

            if ((Input.GetButtonDown("Jump")) && (bCollider.IsTouchingLayers(Ground) && (DialogueManager.isTalking == false)))
            {
                jump();
            }

            if ((Input.GetButtonDown("Jump")) && (jumpCounter < 1 && TimeValueMiniGame.canDoubleJump) && (DialogueManager.isTalking == false) && (doubleJumped == false))
            {
                jump();
                doubleJumped = true;
            }


            //resets double jump variable once player has landed on the ground
            if (bCollider.IsTouchingLayers(Ground))
            {
                resetJumpCounter();
            }
        }
        


    }

    //puts an upward force (a jump) on the player if they can jump.
    void jump()
    {
        myAnimator.SetTrigger("Jump");
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        jumpCounter++;
    }
    // When player lands on ground, jumpCounter will need to be reset so the player can 
    // double jump again.
    void resetJumpCounter()
    {
        jumpCounter = 0;
        doubleJumped = false;
    }

    

}
