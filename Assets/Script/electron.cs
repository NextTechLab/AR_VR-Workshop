using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electron : MonoBehaviour
{

    public GameObject nucleus;
    public float rotationSpeed = 80.0f;

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(nucleus.transform.position, Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
