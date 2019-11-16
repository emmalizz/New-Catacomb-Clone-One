using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D obj;

    public bool isGrounded = false;

    public float speed;
    public float jumpHeight;
    public float dashSpeed;

    private int dashCooldown = 0;

    private bool doJump;
    private bool doDash;

    private float facing = 1;
    private float movementDirection;

    void Start()
    {
        obj = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movementDirection = Input.GetAxis("Horizontal");

        if (movementDirection > 0)
        {
            facing = 1;
        }
        else if (movementDirection < 0)
        {
            facing = -1;
        }

        if (Input.GetButton("Jump"))
        {
            doJump = true;
        }
        else if (Input.GetKey(KeyCode.LeftShift))
        {
            doDash = true;
        }

        if (dashCooldown > 0)
        {
            dashCooldown--;
        }

    }

    private void FixedUpdate()
    {
        Vector2 velocity = new Vector2(movementDirection, 0f);

        obj.MovePosition(obj.position + (velocity * speed * Time.deltaTime));

        if (doJump)
        {
            if (isGrounded)
            {
                obj.AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
            }
            doJump = false;
        }
        if (doDash)
        {
            obj.AddForce(new Vector2(dashSpeed * facing, 0f), ForceMode2D.Impulse);
            doDash = false;
        }
    }
}
