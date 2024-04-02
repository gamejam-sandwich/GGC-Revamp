using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;
    public TMP_Text scoreText;
    public int currentScore = 0;
    public AudioSource plusSound;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + currentScore.ToString();
    }

    public void IncreaseScore(int v)
    {
        currentScore += v;
        plusSound.Play();
        scoreText.text = "Score: " + currentScore.ToString();
    }
}
