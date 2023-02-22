using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour
{

    TextMeshProUGUI scoreText;
    GameObject scoreBoardUI;
    public static int score;
    private int highScore;
    Scene scene;
    private string keyHighScore;
    private string sceneName;


    private void Start()
    {
        gameObject.GetComponent<Shoot>().enabled = true;
        scoreBoardUI = GameObject.FindGameObjectWithTag("ScoreCanvas");
        scoreText = GameObject.FindGameObjectWithTag("ScoreOnBanner").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    private void OnDestroy()
    {
        scene = SceneManager.GetActiveScene();
        sceneName = scene.name;

        switch (sceneName) 
        {
          case "EasyShootingGame":
            keyHighScore = "easyHighScore";
            break;
          case "MediumShootingGame":
            keyHighScore = "mediumHighScore";
            break;
          case "HardShootingGame":
            keyHighScore = "hardHighScore";
            break;
        }


        if(PlayerPrefs.HasKey(keyHighScore))
        {
            if(score > PlayerPrefs.GetInt(keyHighScore))
            {
                highScore = score;
                PlayerPrefs.SetInt(keyHighScore, highScore);
                PlayerPrefs.Save();
            }
        }
        else
        {   
            if(score > highScore)
            {
                highScore = score;
                PlayerPrefs.SetInt(keyHighScore, highScore);
                PlayerPrefs.Save();
            }
        }
        score = 0;
    }
}
