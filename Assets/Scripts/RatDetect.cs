using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatDetect : MonoBehaviour
{
    GameObject Rat;

    void Start()
    {
        Rat = gameObject.transform.parent.gameObject;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Top collided");
        Destroy(Rat);
    }
}
