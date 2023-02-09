using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelGrid : MonoBehaviour
{

    public void playEasy ()
    {
        StaticClass.CrossSceneInformation = 0;
        SceneManager.LoadScene("ShootingGame");
    }

    public void playMedium ()
    {
        StaticClass.CrossSceneInformation = 1;
        SceneManager.LoadScene("ShootingGame");
    }

    public void playHard ()
    {
        StaticClass.CrossSceneInformation = 2;
        SceneManager.LoadScene("ShootingGame");
    }
}
