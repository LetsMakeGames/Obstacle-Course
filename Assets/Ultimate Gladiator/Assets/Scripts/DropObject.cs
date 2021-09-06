using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObject : MonoBehaviour
{
    [SerializeField] float timeToDropMin = 1.0f;
    [SerializeField] float timeToDropMax = 3.0f;
    float timeToDrop = 3;
    float timer;
    Rigidbody rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
    }

    private void Start()
    {
            Randomizer();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timeToDrop && rb.useGravity == false)
        {
            rb.useGravity = true;
            SetTimer();
        }
    }

    void SetTimer()
    {
        timer = 0;
    }

    void Randomizer()
    {
        timeToDrop = Random.Range(timeToDropMin, timeToDropMax);
    }


}
