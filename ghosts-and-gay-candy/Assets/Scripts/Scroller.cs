using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scroller : MonoBehaviour
{
    public float hSpeed = 0.2f;
    public float vSpeed = 0.2f;
    private Renderer re;

    void Start()
    {
        re = GetComponent<Renderer>();
    }
    void Update()
    {
        Vector2 offset = new Vector2(Time.time * hSpeed, Time.time * vSpeed);
        re.material.mainTextureOffset = offset;
    }
}
