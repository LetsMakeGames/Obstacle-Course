using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float xMovement = 0.0f;
    float zMovement = 0.0f;
    float boostSpeed = 1.0f;
    bool isBoost = false;
    [SerializeField] int moveSpeed = 1;
    [SerializeField] int rotateSpeed = 90;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        GetPlayerMovement();
        MovePlayer();
    }

    void GetPlayerMovement()
    {
        if (Input.GetButton("Change Speeds"))
        {
            isBoost = true;
            boostSpeed = 2.0f;

        }
        else
        {
            isBoost = false;
            boostSpeed = 1.0f;
        }

        xMovement = Input.GetAxis("Horizontal") * rotateSpeed * boostSpeed * Time.deltaTime;
        zMovement = Input.GetAxis("Vertical") * moveSpeed * boostSpeed * Time.deltaTime;
    }

    void MovePlayer()
    {
        transform.Translate(0, 0, zMovement);
        transform.Rotate(0, xMovement, 0);
    }
}
