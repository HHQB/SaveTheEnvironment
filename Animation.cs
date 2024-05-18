using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public Sprite RANGEROUTLINESPRITE_3;
    public Sprite RANGEROUTLINESPRITE_2;
    public Sprite RANGEROUTLINESPRITE_1;
    public Sprite RANGEROUTLINESPRITE_0;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D myRigidbody;
    public float horizontalVelocityThreshold = 0.1f; // Threshold for horizontal movement

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        myRigidbody = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            spriteRenderer.sprite = RANGEROUTLINESPRITE_3;
        } 
        else if (Input.GetKey(KeyCode.A)) {
            spriteRenderer.sprite = RANGEROUTLINESPRITE_0;
        } 
        else if (Input.GetKey(KeyCode.D)) {
            spriteRenderer.sprite = RANGEROUTLINESPRITE_1;
        }
        else if (Input.GetKey(KeyCode.S)) {
            spriteRenderer.sprite = RANGEROUTLINESPRITE_2;
        }
        

        // Check if the object is moving straight downward
        if (myRigidbody.velocity.y < 0 && Mathf.Abs(myRigidbody.velocity.x) < horizontalVelocityThreshold) {
            spriteRenderer.sprite = RANGEROUTLINESPRITE_2;
        }
    }
}
