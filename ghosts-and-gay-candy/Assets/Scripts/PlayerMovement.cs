using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    Vector2 mvmt;

    // Update is called once per frame
    void Update()
    {
        mvmt.x = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + mvmt * moveSpeed * Time.fixedDeltaTime);
    }
}
