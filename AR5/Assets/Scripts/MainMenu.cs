using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayShootingGame()
    {
        SceneManager.LoadScene("DifficultyMenu");
    }

        public void PlayInteractingGame()
    {
        SceneManager.LoadScene("InteractGame");
    }

        public void PlayWithSpider()
    {
        SceneManager.LoadScene("SpiderPlayGame");
    }
}
