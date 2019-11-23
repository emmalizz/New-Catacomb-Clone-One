using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatMove : MonoBehaviour
{
    public Rigidbody2D obj;

    public int moveDistance;
    public int speed;
    
    private int facing = 1;
    private int movement = 0;
    void Start()
    {
        obj = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (movement != moveDistance)
        {
            Vector2 velocity = new Vector2(facing, 0f);
            obj.MovePosition(obj.position + (velocity * speed * Time.deltaTime));
            movement++;
        }
        else
        {
            facing *= -1;
            movement = 0;
        }
    }
}
