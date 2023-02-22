using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoDifficulty : MonoBehaviour
{
    public void clickBack ()
    {
        SceneManager.LoadScene("DifficultyMenu");
    }
}
