using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D obj;

    public bool isGrounded = false;

    public float speed;
    public float jumpHeight;

    void Start()
    {
        obj = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 velocity = new Vector2(Input.GetAxis("Horizontal"), 0f);

        obj.MovePosition(obj.position + (velocity * speed * Time.deltaTime));

        if (Input.GetButton("Jump") && isGrounded)
        {
            obj.AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
        }
    }
}
