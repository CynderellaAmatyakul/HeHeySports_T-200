using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleManagment : MonoBehaviour
{
    public void GoToMain()
    {
        SceneManager.LoadScene("Gameplay");
    }

    public void GoToPuz1()
    {
        SceneManager.LoadScene("Puzzle1");
    }

    public void GoToPuz2()
    {
        SceneManager.LoadScene("Puzzle2");
    }

    public void GoToPuz3()
    {
        SceneManager.LoadScene("Puzzle3");
    }
}
