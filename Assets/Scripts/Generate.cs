using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{
    public GameObject obs;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1f, 8f);

       
    }

    void CreateObstacle ()
    {
        Instantiate(obs,new Vector3(10,0,0),Quaternion.identity);
    }
}
