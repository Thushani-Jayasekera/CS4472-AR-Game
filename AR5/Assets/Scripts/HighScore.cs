using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HighScore : MonoBehaviour
{
    TextMeshProUGUI easyhighScoreText;
    TextMeshProUGUI mediumhighScoreText;
    TextMeshProUGUI hardhighScoreText;

    // Start is called before the first frame update
    void Start()
    {
        easyhighScoreText = GameObject.FindGameObjectWithTag("EasyHighScore").GetComponent<TextMeshProUGUI>();
        mediumhighScoreText = GameObject.FindGameObjectWithTag("MediumHighScore").GetComponent<TextMeshProUGUI>();
        hardhighScoreText = GameObject.FindGameObjectWithTag("HardHighScore").GetComponent<TextMeshProUGUI>();

        if(PlayerPrefs.HasKey("easyHighScore"))
        {
            easyhighScoreText.text = "Easy: " + PlayerPrefs.GetInt("easyHighScore").ToString();
        }
        else
        {
            easyhighScoreText.text = "Easy: A highscore has not been set!";
        }

        if(PlayerPrefs.HasKey("mediumHighScore"))
        {
            mediumhighScoreText.text = "Medium: " + PlayerPrefs.GetInt("mediumHighScore").ToString();
        }
        else
        {
            mediumhighScoreText.text = "Medium: A highscore has not been set!";
        }

        if(PlayerPrefs.HasKey("hardHighScore"))
        {
            hardhighScoreText.text = "Hard: " + PlayerPrefs.GetInt("hardHighScore").ToString();
        }
        else
        {
            hardhighScoreText.text = "Hard: A highscore has not been set!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
