using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeDetector : MonoBehaviour
{
    public static EdgeDetector instance;
    [SerializeField] GameObject particle;
    public GameObject warn;
    public bool isFalling;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        SetTF(particle, false);
        isFalling = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isFalling)
        {
            SetTF(warn, false);
            SetTF(particle, true);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            StartCoroutine(WaitBeforeDestroy());
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            isFalling = true;
            SetTF(warn, true);
        }
    } 

    void SetTF(GameObject obj, bool value)
    {
        obj.SetActive(value);
    }

    private IEnumerator WaitBeforeDestroy()
    {
        yield return new WaitForSeconds(1);
        SetTF(particle, false);
        isFalling = false;
    }
}
