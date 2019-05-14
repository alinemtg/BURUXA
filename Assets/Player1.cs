using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player1 : MonoBehaviour {

    public float movementSpeed = 10f;

    Rigidbody2D rb;

    public float movement = 0f;
    public bool lookright = true;


    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
    }

    void FixedUpdate(){
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;

        if(velocity.x>0 && !lookright || velocity.x<0 && lookright){
            Flip();
        }
    }

    void Flip(){
        lookright = !lookright;
        Vector3 charScale = transform.localScale;
        charScale.x *= -1;
        transform.localScale = charScale; 
    } 
}
