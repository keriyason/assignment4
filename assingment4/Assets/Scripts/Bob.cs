using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bob : MonoBehaviour
{
    public float amplitude = 0.5f; // How high it bobs
    public float frequency = 1f;   // How fast it bobs

    private Vector3 startPos;

    void Start()
    {
       
        startPos = transform.position;
    }

    void Update()
    {
         
        float yOffset = Mathf.Sin(Time.time * frequency) * amplitude; //  Y offset 

        transform.position = startPos + new Vector3(0, yOffset, 0); // Offset to the starting position
    }
}