using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCheck : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("We just collided");
        myRigidbody.velocity = Vector2.up * 10;
    }
    private void OnTriggerStay2D(Collider2D collision) {
        Debug.Log("We are still colliding");
        myRigidbody.velocity = Vector2.up * 10;
    }
    private void OnTriggerExit2D(Collider2D collision) {
        Debug.Log("We just stopped colliding");    
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
