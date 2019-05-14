using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class floor : MonoBehaviour
{
    public GameObject maincam;
    public GameObject player1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D colission){

        if (colission.gameObject.tag == "Player"){
            //Game overrrr
            SceneManager.LoadScene("GameOver");
            //print("morreuuuuuuuuuuuuuuuuuuuuuuuuuuu");
            //Destroy (colission.gameObject);
        }
	
    }
}
 