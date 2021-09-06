using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(gameObject.tag == "Walls" && collision.gameObject.tag == "Player")
        {
            Debug.Log("Hey, there's a wall here!");
        }
        

        if(collision.gameObject.tag == "Player" && gameObject.tag != "Win")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;

        } else if (collision.gameObject.tag == "Player" && gameObject.tag == "Win")
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
            Debug.Log("You win!");
        }
        
    }
}
