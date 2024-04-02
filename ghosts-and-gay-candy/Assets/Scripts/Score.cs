using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static Score instance;
    public static int currentScore;
    public static int finalScore;

    public TMP_Text scoreText;
    public AudioSource plusSound;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        var currentScene = SceneManager.GetActiveScene().name;
        if(currentScene == "SampleScene")
        {
            currentScore = 0;
            scoreText.text = "Score: " + currentScore.ToString();
        }
        else
        {
            scoreText.text = "You collected: " + finalScore.ToString() + " pieces!";
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void IncreaseScore(int v)
    {
        currentScore += v;
        plusSound.Play();
        scoreText.text = "Score: " + currentScore.ToString();
        finalScore = currentScore;
    }
}
