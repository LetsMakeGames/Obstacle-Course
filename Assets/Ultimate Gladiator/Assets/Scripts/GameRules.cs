using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRules : MonoBehaviour
{
    string[] gameRules = { "Welcome to Ultimate Gladiator!",
        "Use WASD to move",
        "Look with mouse",
        "Jump with space",
        "Stay within the course bounds!", 
        "Avoid the obstacles and reach the end!"};


    // Start is called before the first frame update
    void Start()
    {
        //PrintGameRules();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintGameRules()
    {
        for(int i = 0; i < gameRules.Length; i++)
        {
            Debug.Log(gameRules[i]);
        }
        
    }
}
