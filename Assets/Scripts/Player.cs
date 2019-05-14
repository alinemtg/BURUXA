using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    // The force which is added when the player jumps
    // This can be changed in the Inspector window
    public Vector2 jumpForce = new Vector2(0, 5);
    public int vidas = 3;

    // Update is called once per frame
    void Update()
    {
        // Jump
        if (Input.GetKeyUp("space"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().AddForce(jumpForce);
        }
        // Die by being off screen
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPosition.y > Screen.height || screenPosition.y < 0)
        {
            Die();
        }


    }

    // Die by collision

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "obstaculos")
        {
            vidas = vidas - 1;
            if (vidas == 0)
            {
                Die();
            }
            Die();
        }
    }

    void Die()
    {
        SceneManager.LoadScene("GameOver2");

        
    }
}
