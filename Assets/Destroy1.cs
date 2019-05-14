using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy1 : MonoBehaviour
{
    public GameObject player;
    public GameObject plataformPrefab;
	public GameObject plataformPrefabJump;
    private GameObject myPlat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*  private void OnTriggerEnter2D(Collider2D colission){

        if (colission.gameObject.tag == "platformJump"){
            Instantiate(plataformPrefabJump, new Vector2 (Random.Range(-8f, 8f ), player.transform.position.y + (Random.Range(10f, 10f))), (Quaternion.identity));
            Destroy (colission.gameObject);
        }
        if (colission.gameObject.tag == "platform"){
            Instantiate(plataformPrefab, new Vector2 (Random.Range(-8f, 8f ), player.transform.position.y + (Random.Range(4f, 4f))), (Quaternion.identity));
            Destroy (colission.gameObject);
        }
	
    } */
}
 