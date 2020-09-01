using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript pm;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Obstacle")
        {
            pm.enabled = false;
            Debug.Log("You Hit Something.");

            FindObjectOfType<GameManager>().GameOver();
        }

        /*if (collision.collider.tag == "Finish")
        {
            pm.enabled = false;
            Debug.Log("Finished");
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
