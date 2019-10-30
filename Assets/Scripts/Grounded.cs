using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    GameObject Player;

    void Start()
    {
        Player = gameObject.transform.parent.gameObject;
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("On ground");
        Player.GetComponent<PlayerMovement>().isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Left ground");
        Player.GetComponent<PlayerMovement>().isGrounded = false;
    }
}
