using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D obj;

    public float speed;
    public float jumpHeight;

    private float distToGround;

    void Start()
    {
        obj = GetComponent<Rigidbody2D>();        
    }

    void Update()
    {
        Vector2 velocity = new Vector2(Input.GetAxis("Horizontal"), 0) ;
        
        if (Input.GetButton("Jump"))
        {
            velocity.y = jumpHeight;
        }

        obj.MovePosition(obj.position + (velocity * speed * Time.deltaTime));
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        // Debug-draw all contact points and normals
        foreach (ContactPoint contact in collisionInfo.contacts)
        {
            Debug.Log("Collision");
        }
    }
}
