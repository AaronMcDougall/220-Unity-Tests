using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSideways : MonoBehaviour
{
    private Rigidbody rb;
    
    public float raycastDistance = 20f;
    private float perlinValue;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        perlinValue = Mathf.PerlinNoise(0f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, raycastDistance))
        {
            rb.AddRelativeTorque(0, perlinValue, 0 );
        }
        
        Debug.DrawRay(transform.position, transform.forward * raycastDistance, Color.yellow);
    }
}
