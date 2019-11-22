using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideCollision : MonoBehaviour
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
        Debug.Log("Side collided");
        Player.GetComponent<PlayerMovement>().sideCollided = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Side left");
        Player.GetComponent<PlayerMovement>().sideCollided = false;
    }
}
