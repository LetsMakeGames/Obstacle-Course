using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    int bumps;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag != "Walls" && collision.gameObject.tag != "Hit" && collision.gameObject.tag != "Win")
        {
            Debug.Log("You've bumped into obstacles this many times: " + bumps);
            bumps++;

            collision.gameObject.tag = "Hit";
        }
    }
}
