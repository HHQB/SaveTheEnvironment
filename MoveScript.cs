using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public BoxCollider2D myBoxCollider2D;
    public float moveSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Using Update for non-physics related transformations
        Vector3 movement = Vector3.zero;

        if (Input.GetKey(KeyCode.A)) {
            movement += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D)) {
            movement += Vector3.right;
        }

        // Apply movement
        transform.position += movement * moveSpeed * Time.deltaTime;
    }

    // FixedUpdate is called at a fixed interval and is independent of frame rate
    void FixedUpdate()
    {
        // Using FixedUpdate for physics-related updates
        if (Input.GetKey(KeyCode.W)) {
            myRigidbody.velocity = Vector2.up * 10;
        }
        if (Input.GetKey(KeyCode.S)) {
            myRigidbody.velocity = Vector2.down * 20;
        }
    }
}