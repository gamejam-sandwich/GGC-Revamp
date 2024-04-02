using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public AudioSource telSound;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Vector2 mvmt;
    bool canTeleport;

    //public float setX;
    public float setY;
    public float setZ;

    // Update is called once per frame
    void Update()
    {
        canTeleport = EdgeDetector.instance.isFalling;

        mvmt.x = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space) && canTeleport)
        {
            rb.transform.position = new Vector3(Random.Range(-1f,1.5f),setY,setZ);
            telSound.Play();
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + mvmt * moveSpeed * Time.fixedDeltaTime);
    }
}
