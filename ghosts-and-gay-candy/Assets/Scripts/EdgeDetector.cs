using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdgeDetector : MonoBehaviour
{
    [SerializeField] GameObject particle;
    public GameObject warn;
    private IEnumerator coroutine;

    // Start is called before the first frame update
    void Start()
    {
        SetTF(particle, false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
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
    }
}
