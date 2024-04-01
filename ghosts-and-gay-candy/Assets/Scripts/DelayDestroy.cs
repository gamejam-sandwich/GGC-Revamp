using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayDestroy : MonoBehaviour
{
    private IEnumerator coroutine;
    public GameObject obstacle;

    // Start is called before the first frame update
    void Start()
    {
        coroutine = WaitAndPrint(Random.Range(3,5));
        StartCoroutine(coroutine);
    }

    private IEnumerator WaitAndPrint(float waitTIme)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTIme);
            obstacle.SetActive(false);
        }
    }

}
