using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform1 : MonoBehaviour {
    public float jumpForce = 10f;
    public Transform player;
    
    Transform cm;
    void start(){
       // cm = GameObject.Find("Camera").GetComponent<Transform>();
       // (cm.GetComponent(Camera) as Camera).enabled = true;
    }
    void Update(){
          cm = GameObject.Find("Main Camera").GetComponent<Transform>();
        if(cm.position.y - gameObject.transform.localPosition.y > 9){
            sumir();
        }
    }
    
    void OnDisable(){
        CancelInvoke();
    }
    void sumir(){
        gameObject.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D collision){

        if (collision.relativeVelocity.y <= 0f){
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

            if (rb!=null) {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }
            
            
        }
        //gameObject.transform.localPosition.y
        print(player.localPosition.y);
        Invoke("sumir",7f);

    }

    private void OnTriggerEnter2D(Collider2D colission){
        print("sumi?");
        Invoke("sumir",7f);
    }

}
