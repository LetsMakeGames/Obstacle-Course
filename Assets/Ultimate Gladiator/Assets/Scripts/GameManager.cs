using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject dropper;
    [SerializeField] GameObject roller;
    [SerializeField] float timeToSpawnMin = 2.0f;
    [SerializeField] float timeToSpawnMax = 6.0f;

    GameRules gameRules;
    GameObject objectToSpawn;
    float height = 10.0f;
    float timer;
    float timeToSpawn = 3.0f;
    float xMin = -47.5f;
    float xMax = 47.5f;
    float zMin = -47.5f;
    float zMax = 47.5f;
    float xMin2 = -72.0f;
    float xMax2 = -52.0f;
    float xMin3 = 72.0f;
    float xMax3 = 52.0f;
    float xPosition;
    float zPosition;
    Vector3 position;
    

    // Start is called before the first frame update
    void Start()
    {
        gameRules = gameObject.GetComponent<GameRules>();
        gameRules.PrintGameRules();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= timeToSpawn)
        {
            SetTimer();
            Randomizer();
            Instantiate(objectToSpawn, position, Quaternion.identity);
        }
    }

    void SetTimer()
    {
        timer = 0;
    }

    void Randomizer()
    {
        float random = Random.Range(1, 101);
        zPosition = Random.Range(zMin, zMax);
        timeToSpawn = Random.Range(timeToSpawnMin, timeToSpawnMax);

        if (random <= 50)
        {
            xPosition = Random.Range(xMin, xMax);
            position = new Vector3(xPosition, height, zPosition);
            objectToSpawn = dropper;

        } else if (random >= 51 && random <= 75)
        {
            xPosition = Random.Range(xMin2, xMax2);
            position = new Vector3(xPosition, height, zPosition);
            objectToSpawn = roller;
        } else
        {
            xPosition = Random.Range(xMin3, xMax3);
            position = new Vector3(xPosition, height, zPosition);
            objectToSpawn = roller;
        }
        
    }
}
