using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    public Vector2 velocity = new Vector2(-4, 0);
    public float range = 3;

    // Use this for initialization

    private void Start()
    {
        transform.position = new Vector3(transform.position.x + 18, transform.position.y - range * Random.value, transform.position.z);
    }

    private void Update()
    {
        transform.position -= new Vector3(0.07f, 0, 0);
    }
    
}
