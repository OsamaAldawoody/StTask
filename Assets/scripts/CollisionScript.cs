using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    int score = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
        
        if (collision.gameObject.tag == "Coin")
        {
            score++;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "Bag")
        {
           
        }
    }
}
