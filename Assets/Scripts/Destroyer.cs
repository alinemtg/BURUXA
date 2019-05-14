using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject player;
    public GameObject plataformPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D colission)
    {
        if (colission.gameObject.tag == "obstaculos")
        {
            Instantiate(plataformPrefab, new Vector2(Random.Range(-8f, 8f), player.transform.position.y + (Random.Range(4f, 4f))), (Quaternion.identity));
            Destroy(colission.gameObject);
        }

    }
}