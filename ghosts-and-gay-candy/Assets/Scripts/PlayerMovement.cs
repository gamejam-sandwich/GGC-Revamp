using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //[SerializeField] GameObject particle;

    private IEnumerator coroutine;
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    //public GameObject warn;
    public Vector2 mvmt;

    public float setX;
    public float setY;
    public float setZ;

    void Start()
    {
        //particle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        mvmt.x = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //SetTrueFalse(warn, false);
            //SetTrueFalse(particle, true);
            rb.transform.position = new Vector3(setX,setY,setZ);
            //coroutine = WaitBeforeDestroy(1);
        }

        /*if (Input.GetKeyUp(KeyCode.Space))
        {
            StartCoroutine(coroutine);
        }*/
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + mvmt * moveSpeed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        //SetTrueFalse(warn, true);
    }

    void SetTrueFalse(GameObject obj, bool value)
    {
        obj.SetActive(value);
    }

    private IEnumerator WaitBeforeDestroy(float waitTIme)
    {
        yield return new WaitForSeconds(waitTIme);
        //SetTrueFalse(particle, false);
    }
}
