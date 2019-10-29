using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stalactite : MonoBehaviour
{
    private float time;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (Player.transform.position.x == this.transform.position.x) this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic; //stalactite falls when player is directly under it
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            print("ouuuuuch!"); //replace with health decrement when health implemented
        }
    }
}
