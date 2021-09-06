using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] float spinPower = 1.0f;
    [SerializeField] float xRotation, zRotation = 0.0f;
    [SerializeField] float yRotation = 1.0f;
    Vector3 spin;

    // Start is called before the first frame update
    void Start()
    {
        spin = new Vector3(xRotation, yRotation, zRotation) * spinPower;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spin);
    }
}
